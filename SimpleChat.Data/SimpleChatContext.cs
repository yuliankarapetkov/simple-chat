using Microsoft.EntityFrameworkCore;

namespace SimpleChat.Data
{
    public class SimpleChatContext : DbContext
    {
        public SimpleChatContext(DbContextOptions<SimpleChatContext> options)
            : base(options)
        { }

        public DbSet<Message> Messages { get; set; }
    }
}
