using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFAssignment01.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string ISBN { get; set; } = null!;
        public decimal Price { get; set; }
        public int NumOfPages { get; set; }
        public int PublishYear { get; set; }
        public bool InStock { get; set; }

    }
}
