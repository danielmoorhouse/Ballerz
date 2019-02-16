using System;
using System.Collections.Generic;

namespace Ballerz.Models.Profile
{
    public class ProfileListModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileImageUrl { get; set; }
        public string UserRating { get; set; }
        public DateTime MemberSince { get; set; }
        public IEnumerable<Ballerz.Data.Models.Profile> Profiles { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Location { get; set; }
        public string FlagUrl { get; set; }
        public string TeamBadge { get; set; }

    }
}