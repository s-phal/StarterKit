namespace StarterKit.Application.Models
{
    public class BaseModel
    {
        public Guid guid { get; set; } = Guid.NewGuid();
        public DateTime created_at { get; set; } = DateTime.UtcNow;
        public DateTime updated_at { get; set; } = DateTime.UtcNow;
        public bool is_active { get; set; } = true;
    }
}
