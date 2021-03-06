using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VismaE2interRPWDWEDN.Data;
using VismaE2interRPWDWEDN.Models;

namespace VismaE2interRPWDWEDN.Pages.Stillinger
{
    public class EditModel : PageModel
    {
        private readonly VismaE2interRPWDWEDN.Data.VismaE2interRPWDWEDNContext _context;

        public EditModel(VismaE2interRPWDWEDN.Data.VismaE2interRPWDWEDNContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Stilling).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StillingExists(Stilling.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool StillingExists(int id)
        {
            return _context.Stilling.Any(e => e.ID == id);
        }
    }
}
