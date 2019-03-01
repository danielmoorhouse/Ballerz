using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Ballerz.Services.Implementations
{

    public class NotificationService : INotification
    {
         private readonly IApplicationUser _userService;
         private readonly ApplicationDbContext _db;
        

           public NotificationService(IApplicationUser userService, ApplicationDbContext db)
        {
            _userService = userService;
            _db = db;
        }
        public async Task<Notification> CreateNotification(string toUser, string fromUser, string notificationMessage)
        {
                var notification = new Notification
            {
                ToUser = await _userService.GetByUsername(toUser),
                FromUser = await _userService.GetByUsername(fromUser),
                Message = notificationMessage,
                Viewed = false,
                Timestamp = DateTime.Now
            };

            return notification;
        }

        public Task<List<Notification>> GetNotifications(string userName, bool includeViewed = false)
        {
              var notifications = _db.Notifications.Where(n => n.ToUser.UserName == userName);

            return includeViewed ? notifications.ToListAsync() : notifications.Where(n => !n.Viewed).ToListAsync();
        }

        public async Task MarkNotificationsViewed(string userName)
        {
            var notifications = _db.Notifications.Where(n => n.ToUser.UserName == userName).ToList();
            notifications.ForEach(n => n.Viewed = true);

            await _db.SaveChangesAsync();
        }

        public async Task SendNotification(Notification notification)
        {
            if (notification == null || notification.FromUser.Id == notification.ToUser.Id) return;

            _db.Notifications.Add(notification);
            await _db.SaveChangesAsync();
        }
    }
}