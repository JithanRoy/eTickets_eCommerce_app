using EticketsProjects2.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int ProducerId { get; set; }

        [Display(Name = "Profile Picture")]
        public String ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        public String FullName { get; set; }

        [Display(Name = "Biography")]
        public String Bio { get; set; }

        //RelationShips
        public List<Movie> Movies { get; set; }
        public int ActorId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
