using System.ComponentModel.DataAnnotations;

namespace Hobbies.Models
{
    public class Link
    {
        [Key]
        public int LinkID { get; set; }
        [Required]
        public string LinkURL { get; set; }
        [Required]
        public Person Person { get; set; }
        [Required]
        public Interest Interest { get; set; }
    }
}