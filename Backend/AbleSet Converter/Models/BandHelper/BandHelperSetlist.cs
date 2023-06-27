namespace AbleSet_Converter.Models.BandHelper
{
    public class BandHelperSetlist
    {
        public ICollection<BandHelperSong> Songs { get; set; } = new List<BandHelperSong>();
    }
}
