using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaumovaValeriiaDU2.Models
{
    public class DTO
    {
        public int Id { get; set; }

        public string Category { get; set; }

        public string Product { get; set; }

        public DateTime Date { get; set; }

        public string Text { get; set; }
        public string Email { get; set; }

        public string File { get; set; }
        public Report response { get; set; }
    }
}
