using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using VCDRent.Models.Invent;

namespace VCDRent.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public partial class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string profilePictureUrl { get; set; } = "/images/empty_profile.png";
        public bool isSuperAdmin { get; set; } = false;
       

        [Display(Name = "Roles")]
        public bool ApplicationUserRole { get; set; } = false;
    }

}
