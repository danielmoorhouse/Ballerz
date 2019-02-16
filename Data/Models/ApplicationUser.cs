using Microsoft.AspNetCore.Identity;
using System;

namespace Ballerz.Data.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Location { get; set; }
        public int Rating { get; set; }
        public string ProfileImageUrl { get; set; }
        public int TeamId { get; set; }
        public DateTime MemberSince { get; set; }
        public bool IsActive { get; set; }
    }
}
