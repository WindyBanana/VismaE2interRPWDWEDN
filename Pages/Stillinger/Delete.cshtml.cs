using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VismaE2interRPWDWEDN.Data;
using VismaE2interRPWDWEDN.Models;

namespace VismaE2interRPWDWEDN.Pages.Stillinger
{
    public class DeleteModel : PageModel
    {
        private readonly VismaE2interRPWDWEDN.Data.VismaE2interRPWDWEDNContext _context;

        public DeleteModel(VismaE2interRPWDWEDN.Data.VismaE2interRPWDWEDNContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Stilling Stilling { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Stilling = await _context.Stilling.FirstOrDefaultAsync(m => m.ID == id);

            if (Stilling == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Stilling = await _context.Stilling.FindAsync(id);

            if (Stilling != null)
            {
                _context.Stilling.Remove(Stilling);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
