using System.Collections.Generic;
using Ballerz.Data.Models;
using Ballerz.Models.Post;
using Ballerz.Models.Profile;
using Ballerz.Models.Teams;

namespace Ballerz.Models.Home
{
    public class HomeIndexModel
    {
         public string SearchQuery { get; set; }
        public IEnumerable<PostListingModel> LatestPosts { get; set; }
        public IEnumerable<ApplicationUser> Users { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public IEnumerable<ProfileListModel> Profile { get; set; }
        public IEnumerable<TeamListingModel> Teams { get; set; }
        public string CountryFlag { get; set; }
        public string Location { get; set; }
        public string MemberSince { get; set; }
    }
}