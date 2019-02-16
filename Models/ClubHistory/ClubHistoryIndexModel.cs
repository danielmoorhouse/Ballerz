using System.Collections.Generic;
using Ballerz.Models.ClubHistory;

namespace Ballerz.Models.ClubHistory
{
    public class ClubHistoryIndexModel
    {
        public IEnumerable<ClubHistoryListingModel> HistoryList { get; set; }
    }
}