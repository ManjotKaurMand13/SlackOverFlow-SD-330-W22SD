namespace StackOverflow.Models;

public class Answer
{
    public int Id { get; set; }
    public string Body { get; set; }
    public Question Question { get; set; }
    public int? QuestionId { get; set; }
    public string? UserId { get; set; }
    public virtual ApplicationUser User { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public bool IsCorrect { get; set; }
    public int Reputation { get; set; } = 0;
    
    public virtual ICollection<Comment> Comments { get; set; }
}