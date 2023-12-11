namespace StarterKit.Application.Models
{
    public class Todo : BaseModel
    {
        public int todo_id { get; set; }
        public string title { get; set; }
        public string details { get; set; }

    }
}
