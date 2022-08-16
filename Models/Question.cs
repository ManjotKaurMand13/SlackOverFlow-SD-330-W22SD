namespace StackOverflow.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string? UserId { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public ICollection<Answer> Answers { get; set; } = new HashSet<Answer>();
        public ICollection<Vote> Votes { get; set; } = new HashSet<Vote>();
    }
}