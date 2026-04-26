using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment02.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int MaxAttendees { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; } = null!;


        public ICollection<Session> Sessions { get; set; } = new List<Session>();
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    }
}
