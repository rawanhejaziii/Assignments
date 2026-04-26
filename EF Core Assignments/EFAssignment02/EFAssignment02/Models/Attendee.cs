using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment02.Models
{
    public class Attendee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string FullName { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        public string Street { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        [Required]
        public string Country { get; set; } = null!;

        [Required]
        public string PostalCode { get; set; } = null!;

        public Badge? Badge { get; set; }

        public ICollection<Registration> Registrations { get; set; }
            = new List<Registration>();
    }
}
