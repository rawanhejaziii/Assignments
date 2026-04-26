using EFAssignment02.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment02.Models
{
    public class Badge
    {
        public int Id { get; set; }

        public int BadgeNumber { get; set; }
        public DateTime IssuedDate { get; set; }

        public BadgeTier Tier { get; set; }

        // FK (One-to-One)
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = null!;
    }
}
