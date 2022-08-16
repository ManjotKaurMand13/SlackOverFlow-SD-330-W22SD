namespace StackOverflow.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string? UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int? AnswerId { get; set; }
        public Answer Answer { get; set; }
        
    }
}