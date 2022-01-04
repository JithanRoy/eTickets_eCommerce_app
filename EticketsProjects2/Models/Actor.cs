using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Display(Name = "Profile Picture")]
        public String ProfilePictureURL { get; set; }

        [Display(Name = "Full name")]
        public String FullName { get; set; }

        [Display(Name = "Biography")]
        public String Bio { get; set; }

        //RelationShips
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
