namespace AbleSet_Converter.Models.AbleSet
{
    public class AbleSetSetlist
    {
        public string Name { get; set; }
        public ICollection<AbleSetSong> Songs { get; set; } = new List<AbleSetSong>();
    }
}
