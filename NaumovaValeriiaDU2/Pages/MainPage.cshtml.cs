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
    public class IndexModel : PageModel
    {
        private readonly NaumovaValeriiaDU2.Models.ApplicationContext _context;

        public IndexModel(NaumovaValeriiaDU2.Models.ApplicationContext context)
        {
            _context = context;
        }

        public IList<Message> Request { get;set; }
        public Message Request1 { get;set; }

        public void OnGet()
        {

            if(_context.Requests.Count() >= 10 )
            {
                Request = _context.Requests.Where(n => n.response == null).OrderByDescending(x => x.Date).ToList().GetRange(0, 10);
                
            }else
            {
                Request = _context.Requests.Where(n => n.response == null).OrderByDescending(x => x.Date).ToList();
            }
            
        }

        public ActionResult OnPostDownloadFile(int id)
        {
            Request1 = _context.Requests.FirstOrDefault(m => m.Id == id);
            

            if (Request1.File != null)
            {
                Random rnd = new Random();
                char[] randomChar = new char[] { (char)rnd.Next('a', 'z'), (char)rnd.Next('a', 'z'), (char)rnd.Next('1', '9'), (char)rnd.Next('1', '9') };


                return File(Request1.File, System.Net.Mime.MediaTypeNames.Application.Octet, new string(randomChar));
            }

            return NotFound();
            
        }
    }
}
