using System.Data.Entity;
using SimpleChat.Models;
  
namespace SimpleChat.DAL
{

    public class SiteContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        public DbSet<Chat> Chats { get; set; }
    }
}