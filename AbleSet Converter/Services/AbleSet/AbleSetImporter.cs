using AbleSet_Converter.Models.AbleSet;
using Newtonsoft.Json;

namespace AbleSet_Converter.Services.AbleSet
{
    public class AbleSetImporter
    {
        public Task<AbleSetSetlist> Import(string filename)
        {
            string rawText = File.ReadAllText(filename);
            var setlist = new AbleSetSetlist
            {
                Songs = JsonConvert.DeserializeObject<ICollection<AbleSetSong>>(rawText) ?? new List<AbleSetSong>()
            };

            return Task.FromResult(setlist);
        }
    }
}
