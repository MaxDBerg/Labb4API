using System.ComponentModel.DataAnnotations;
using Hobbies.Models;
namespace Hobbies.Dtos
{
    public class LinkReadDto
    {
        //[Key]
        //public int LinkID { get; set; }
        [Required]
        public string LinkURL { get; set; }
        //[Required]
        //public Person Person { get; set; }
        [Required]
        public Interest Interest { get; set; }
    }
}