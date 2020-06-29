using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NaumovaValeriiaDU2.Models;

namespace NaumovaValeriiaDU2
{
    public class DetailsModel : PageModel
    {
        private readonly NaumovaValeriiaDU2.Models.ApplicationContext _context;

        public DetailsModel(NaumovaValeriiaDU2.Models.ApplicationContext context)
        {
            _context = context;
        }

        public List<Message> Request { get; set; }

        public void OnGet()
        {
            if(_context.Requests.Count() != 0)
            {
                Request = _context.Requests.Where(n => n.response == null).OrderByDescending(x => x.Date).ToList();
            }
            
        }
    }
}
