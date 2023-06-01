using System.ComponentModel.DataAnnotations;
using Hobbies.Models;

namespace Hobbies.Dtos
{
    public class LinkCreateDto
    {
        [Required]
        public string LinkURL { get; set; }
        [Required]
        public int PersonID { get; set; }
        [Required]
        public int InterestID { get; set; }
    }
}