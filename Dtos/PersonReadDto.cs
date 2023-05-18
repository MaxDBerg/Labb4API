using System.ComponentModel.DataAnnotations;

namespace Hobbies.Dtos
{
    public class PersonReadDto
    {
        //[Key]
        //public int PersonID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }

    }
}