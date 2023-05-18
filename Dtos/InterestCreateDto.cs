using System.ComponentModel.DataAnnotations;

namespace Hobbies.Dtos
{
    public class InterestCreateDto
    {
        [Required]
        public string Description { get; set; }
    }
}