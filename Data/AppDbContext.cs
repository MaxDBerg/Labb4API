using Hobbies.Models;
using Microsoft.EntityFrameworkCore;

namespace Hobbies.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Link> Links { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Interest>().HasData(new Interest { InterestID = 1, Description = "Fotboll" });
            modelBuilder.Entity<Interest>().HasData(new Interest { InterestID = 2, Description = "Golf" });
            modelBuilder.Entity<Interest>().HasData(new Interest { InterestID = 3, Description = "Tennis" });
            modelBuilder.Entity<Interest>().HasData(new Interest { InterestID = 4, Description = "Bordtennis" });
            
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 1, Name = "Peter Larsson", Email = "Peter.Larsson@gmail.com", Phone = "873298479" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 2, Name = "Lars Petersson", Email = "Lars.Petersson@gmail.com", Phone = "873298479" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 3, Name = "Maja Larsson", Email = "Maja.Larsson@gmail.com", Phone = "873298479" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonID = 4, Name = "Filip Majasson", Email = "Filip.Majasson@gmail.com", Phone = "873298479" });
            
        }
    }
}