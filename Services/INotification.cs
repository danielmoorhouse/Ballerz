using System.Collections.Generic;
using System.Threading.Tasks;
using Ballerz.Data.Models;

namespace Ballerz.Services
{
    public interface INotification
    {
          Task<Notification> CreateNotification(string toUser, string fromUser, string notificationMessage);
        Task SendNotification(Notification notification);
        Task MarkNotificationsViewed(string userName);
        Task<List<Notification>> GetNotifications(string userName, bool includeViewed = false); 
    }
}