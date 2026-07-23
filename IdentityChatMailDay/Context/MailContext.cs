using IdentityChatMailDay.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityChatMailDay.Context
{
    public class MailContext : IdentityDbContext<AppUser>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JQG1QG1\\SQLEXPRESS;initial Catalog=EmailChatDb;integrated Security=true;trust server certificate=true;");
        }

        public DbSet<Message> Messages {get; set;}


    }
}
