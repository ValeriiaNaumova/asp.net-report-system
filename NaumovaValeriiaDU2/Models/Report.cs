using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NaumovaValeriiaDU2.Models
{
    public class Report
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Required]
        public string Text { get; set; }
        public DateTime Date { get; set; }

        [Column(TypeName = "varbinary(max)")]
        public byte[] File { get; set; }

    }
}
