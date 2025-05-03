namespace FloraSync.Models.Entities
{
    public class DiaryImage
    {
        public int Id { get; set; }
        public string FileName { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public DateTime Uploaded { get; set; } = DateTime.UtcNow;
    }
}
