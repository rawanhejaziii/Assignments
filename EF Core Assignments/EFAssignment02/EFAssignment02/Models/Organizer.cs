using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment02.Models
{
    public class Organizer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(100)]
        public string? CompanyName { get; set; }

        public bool IsVerified { get; set; }

        [MaxLength(500)]
        public string? Bio { get; set; }

        [Url]
        public string? WebsiteLink { get; set; }

        public string? Logo { get; set; }

        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}


