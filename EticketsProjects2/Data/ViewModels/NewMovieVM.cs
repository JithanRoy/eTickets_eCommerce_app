using eTickets.Data;
using EticketsProjects2.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Name is required")]
        public String Name { get; set; }

        [Display(Name = "Movie description")]
        [Required(ErrorMessage = "Description is required")]
        public String Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }
        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required")]
        public String ImageURL { get; set; }
        [Display(Name = "Movie start Date")]
        [Required(ErrorMessage = "Start Date is required")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Movie end Date")]
        [Required(ErrorMessage = "End Date is required")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Select a catagory")]
        [Required(ErrorMessage = "Movie catagory is required")]
        public MovieCategory MovieCategory { get; set; }
        //RelationShips
        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is required")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select cinema")]
        [Required(ErrorMessage = "Movie cinema is required")]
        public int CinemaId { get; set; }
        [Display(Name = "Select producer")]
        [Required(ErrorMessage = "Movie producer is required")]
        public int ProducerId { get; set; }
      
    }
}
