namespace AbleSet_Converter.Models.AbleSet
{
    public class AbleSetSong
    {
        public Guid Id { get; set; }
        public decimal Time { get; set; }
        public string LastKnownName { get; set; }
        public string Duration { get; set; }
        public decimal Tempo { get; set; }
        public int Order { get; set; }
    }
}
