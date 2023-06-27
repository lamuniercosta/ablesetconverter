using AbleSet_Converter.Models.AbleSet;
using AbleSet_Converter.Models.BandHelper;

namespace AbleSet_Converter.Services
{
    public class SetListProcessor
    {
        public static Task<AbleSetSetlist> Process(AbleSetSetlist original, BandHelperSetlist modifier)
        {
            var setlist = new AbleSetSetlist();
            foreach (var item in modifier.Songs)
            {
                var song = original.Songs.SingleOrDefault(x=>x.LastKnownName.Contains(item.Name, StringComparison.OrdinalIgnoreCase));
                song!.Order = item.Order;
                setlist.Songs.Add(song);
            }
            return Task.FromResult(setlist);
        }
    }
}
