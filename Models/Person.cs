using System.ComponentModel.DataAnnotations;

namespace Hobbies.Models
{
    public class Person
    {   
        [Key]
        public int PersonID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public ICollection<Interest> Interests { get; set; }
    }
}