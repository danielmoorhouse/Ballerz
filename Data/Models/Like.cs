using System;
using Ballerz.Forums.Models;

namespace Ballerz.Data.Models
{
    public class Like
    {
        public int Id { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual Post Post { get; set; }

        public DateTime Timestamp { get; set; }
    }
}