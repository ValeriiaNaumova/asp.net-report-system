using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NaumovaValeriiaDU2.Models;

namespace NaumovaValeriiaDU2
{
    public class EditModel : PageModel
    {
        private  NaumovaValeriiaDU2.Models.ApplicationContext _context;

        public EditModel(NaumovaValeriiaDU2.Models.ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Message Request { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Request = await _context.Requests.FirstOrDefaultAsync(m => m.Id == id);

            if (Request == null)
            {
                return NotFound();
            }
            return Page();
        }


        public async Task<IActionResult> OnPostAsync(string Text, IFormFile Upload, int id)
        {
            byte[] file = null;
            Request = await _context.Requests.FirstOrDefaultAsync(m => m.Id == id);

            using (var memoryStream = new MemoryStream())
            {
                await Upload.CopyToAsync(memoryStream);
                file = memoryStream.ToArray();
            }

            if (Request != null)
            {
                Request.response = new Report { Date = DateTime.Now, Text = Text, File = file };
            }
            

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestExists(Request.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./MainPage");
        }

        private bool RequestExists(int id)
        {
            return _context.Requests.Any(e => e.Id == id);
        }

        public ActionResult OnPostDownloadFilefromEdit(int id)
        {
            if (Request.File != null)
            {
                Random rnd = new Random();
                char[] randomChar = new char[] { (char)rnd.Next('a', 'z'), (char)rnd.Next('a', 'z'), (char)rnd.Next('1', '9'), (char)rnd.Next('1', '9') };


                return File(Request.File, System.Net.Mime.MediaTypeNames.Application.Octet, new string(randomChar));
            }

            return NotFound();

        }

    }
}
