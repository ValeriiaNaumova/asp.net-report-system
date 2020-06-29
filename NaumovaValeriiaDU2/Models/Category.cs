using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaumovaValeriiaDU2.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string NameOfCategory { get; set; }
    }
}
