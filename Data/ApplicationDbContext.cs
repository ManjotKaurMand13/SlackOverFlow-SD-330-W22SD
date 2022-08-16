using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StackOverflow.Models;

namespace StackOverflow.Data {
    public class ApplicationDbContext : IdentityDbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }
        public DbSet<StackOverflow.Models.Question>? Questions { get; set; }
        public DbSet<StackOverflow.Models.Answer>? Answers { get; set; }
        public DbSet<StackOverflow.Models.Comment>? Comments { get; set; }
        public DbSet<StackOverflow.Models.Vote>? Vote { get; set; }
    }
}