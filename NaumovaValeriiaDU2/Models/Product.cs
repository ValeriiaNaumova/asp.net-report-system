using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaumovaValeriiaDU2.Models
{
    public class Product
    {
        [Key]
        public string NameOfProduct { get; set; }
        public int CategoryId { get; set; }
    }
}
