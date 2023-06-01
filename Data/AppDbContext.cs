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
            
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 1, LinkURL = "https://www.svenskfotboll.se/", PersonID = 1, InterestID = 1 });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 2, LinkURL = "https://www.fotbollskanalen.se/", PersonID = 1, InterestID = 1 });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 3, LinkURL = "https://www.golf.se/", PersonID = 2, InterestID = 2 });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 4, LinkURL = "https://www.golf.se/", PersonID = 3, InterestID = 2 });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 5, LinkURL = "https://www.golf.se/", PersonID = 4, InterestID = 2 });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 6, LinkURL = "https://www.tennis.se/", PersonID = 2, InterestID = 3 });
            modelBuilder.Entity<Link>().HasData(new Link { LinkID = 7, LinkURL = "https://www.tennis.se/", PersonID = 3, InterestID = 3 });

            modelBuilder.Entity<Person>()
                        .HasMany(p => p.Interests)
                        .WithMany(i => i.Persons)
                        .UsingEntity(j => j.HasData(
                            new { PersonsPersonID = 1, InterestsInterestID = 1 },
                            new { PersonsPersonID = 1, InterestsInterestID = 2 },
                            new { PersonsPersonID = 2, InterestsInterestID = 3 },
                            new { PersonsPersonID = 3, InterestsInterestID = 1 },
                            new { PersonsPersonID = 4, InterestsInterestID = 4 }
                        ));
        }
    }
}