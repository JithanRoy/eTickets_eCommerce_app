using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EticketsProjects2.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Full name")]
        public string FullName { get; set; }
    }
}
