using AbleSet_Converter.Models.BandHelper;

namespace AbleSet_Converter.Services.BandHelper
{
    public class BandHelperImporter
    {
        public Task<BandHelperSetlist> Import(string filename)
        {
            var setlist = new BandHelperSetlist();
            var rawText = File.ReadAllLines(filename);
            foreach (var line in rawText)
            {
                if (string.IsNullOrEmpty(line))
                {
                    continue;
                }
                if (char.IsDigit(line[0]))
                {
                    var rawSong = line.Split('-');
                    var song = new BandHelperSong
                    {
                        Order = int.Parse(rawSong[0].Trim()),
                        Name = rawSong[1].Trim(),
                        Band = rawSong[2].Trim(),
                        Key = rawSong[3].Trim()
                    };

                    setlist.Songs.Add(song);
                    continue;
                }
                continue;
            }
            return Task.FromResult(setlist);
        }
    }
}
