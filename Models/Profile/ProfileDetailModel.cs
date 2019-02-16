using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Ballerz.Forums.Models;

namespace Ballerz.Models.Profile
{
    public class ProfileDetailModel
    {
         public int Id { get; set; }
        public string UserId { get; set; }
      
            public string UserName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Location { get; set; }
            public string Email { get; set; }
            public string ProfileImageUrl { get; set; }
            public int PostCount { get; set; }

            public int TeamId { get; set; }
            
           public string TeamName { get; set; }
           public string TeamBadgeUrl { get; set;}
            
             public string ShortDescription { get; set; }
            public int CountryId { get; set; }
            public string CountryFlagUrl { get; set; }
            public string CountryName { get; set; }
            
            public string UserRating { get; set; }
            
            public bool OwnProfile { get; set; }

            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            public DateTime MemberSince { get; set; }
            public virtual IEnumerable<Ballerz.Forums.Models.Post> Posts { get; set; }
            public virtual IEnumerable<PostReply> Replies { get; set; }
            public int ReplyCount { get; set; }
            public bool IsAdmin { get; set; }
    }
}