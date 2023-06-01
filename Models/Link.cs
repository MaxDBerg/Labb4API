using System.ComponentModel.DataAnnotations;

namespace Hobbies.Models
{
    public class Link
    {
        [Key]
        public int LinkID { get; set; }
        [Required]
        public string LinkURL { get; set; }
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int InterestID { get; set; }
        public Interest Interest { get; set; }
    }
}