using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment02.Models
{
    public class Registration
    {
        public int Id { get; set; }

        public DateTime RegistrationDateTime { get; set; }
        public string? OptionalNote { get; set; }

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = null!;

        public int EventId { get; set; }
        public Event Event { get; set; } = null!;
    }
}
