using System.Collections.Generic;

namespace Ballerz.Models.Profile
{
    public class ProfileIndexModel
    {
        public IEnumerable<ProfileListModel> Profiles { get; set; }
    }
}