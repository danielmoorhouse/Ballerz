using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ballerz.KnowledgeBase.Models;

namespace Ballerz.Data.Models
{
    public class Profile
    {
        public int Id { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
        public string UserId { get; set; }
         [Required]
            [StringLength(20, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            public string UserName { get; set; }
            [Required]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }
            [Required]
            public int TeamId { get; set; }
            public DateTime MemberSince { get; set; }
            
            public string ShortDescription { get; set; }
            public Teams Teams { get; set; }
            public int CountryId { get; set; }
            public Countries Countries { get; set; }
            public string ProfileImageUrl { get; set; }

            public string Location { get; set; }
            public string UserRating { get; set; }
            public bool IsAdmin { get; set; }
    }
}