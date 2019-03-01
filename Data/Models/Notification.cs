using System;
using System.ComponentModel.DataAnnotations;

namespace Ballerz.Data.Models
{
    public class Notification
    {
          public int Id { get; set; }

        public virtual ApplicationUser ToUser { get; set; }

        public virtual ApplicationUser FromUser { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "Notification must be less than 255 characters")]
        public string Message { get; set; }

        public bool Viewed { get; set; }

        public DateTime Timestamp { get; set; }
    }
}