using EticketsProjects2.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is requered")]
        public String ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="FullName is Required")]
        public String FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage ="Biography is Required")]
        public String Bio { get; set; }

        //RelationShips
        public List<Movie> Movies { get; set; }
        
    }
}
