using System.ComponentModel.DataAnnotations;

namespace Hobbies.Dtos
{
    public class InterestReadDto
    {
        //[Key]
        //public int InterestID { get; set; }
        [Required]
        public string Description { get; set; }

    }
}