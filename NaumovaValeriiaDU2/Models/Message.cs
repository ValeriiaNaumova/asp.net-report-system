using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NaumovaValeriiaDU2.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName="nvarchar(50)")]
        public string Category { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Product { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Required]
        public string Text { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Email { get; set; }

        [Column(TypeName = "varbinary(max)")]
        public byte[] File { get; set; } 
        public Report response { get; set; }

    }
}
