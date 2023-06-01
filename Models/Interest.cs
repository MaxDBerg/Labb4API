using System.ComponentModel.DataAnnotations;

namespace Hobbies.Models
{
    public class Interest
    {
        [Key]
        public int InterestID { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public ICollection<Person> Persons { get; set; }
        [Required]
        public ICollection<Link> Links { get; set; }
    }
}