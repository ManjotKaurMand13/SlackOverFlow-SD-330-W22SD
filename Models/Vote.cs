namespace StackOverflow.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int? AnswerId { get; set; }
        public Answer Answer { get; set; }
        public int VoteValue { get; set; } = 0;
        
        public virtual ICollection<ApplicationUser> Users { get; set; }

        public Vote()
        {
        }

        public Vote(string userId, int voteValue)
        {
            UserId = userId;
            VoteValue = voteValue;
        }
    }
}