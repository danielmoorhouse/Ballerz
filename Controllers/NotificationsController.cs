using System.Linq;
using System.Threading.Tasks;
using Ballerz.Data.Models;
using Ballerz.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ballerz.Controllers
{
    public class NotificationsController : Controller
    {
         private readonly ApplicationDbContext _db;
        private readonly INotification _notificationService;

        public NotificationsController(INotification notificationService, ApplicationDbContext db)
        {
            _notificationService = notificationService;
            _db = db;
        }

        public int Count()
        {
            var notifications = _notificationService.GetNotifications(User.Identity.Name, includeViewed: false);
            return notifications.Result.Count;
        }

        [HttpGet]
        public async Task<ActionResult> Index(string userId)
        {
            var notifications = _db.Notifications.Where(n => n.ToUser.Id == userId).ToList();

            await _notificationService.MarkNotificationsViewed(User.Identity.Name);

            return View(notifications);
        }
    }
}