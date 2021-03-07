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

namespace VismaE2interRPWDWEDN.Pages.Ansatte
{
    public class EditModel : PageModel
    {
        private readonly VismaE2interRPWDWEDN.Data.VismaE2interRPWDWEDNContext _context;

        public EditModel(VismaE2interRPWDWEDN.Data.VismaE2interRPWDWEDNContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Ansatt Ansatt { get; set; }
        public SelectList Stillinger { get; set; }
        public SelectList Oppgaver { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            IQueryable<string> stillingQuery = from s in _context.Stilling
                                               orderby s.Name
                                               select s.Name;
            Stillinger = new SelectList(await stillingQuery.ToListAsync());

            IQueryable<string> oppgaveQuery = from o in _context.Oppgave
                                               orderby o.Oppgavetittel
                                               select o.Oppgavetittel;
            Oppgaver = new SelectList(await oppgaveQuery.ToListAsync());

            Ansatt = await _context.Ansatt.FirstOrDefaultAsync(m => m.ID == id);

            if (Ansatt == null)
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

            _context.Attach(Ansatt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnsattExists(Ansatt.ID))
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

        private bool AnsattExists(int id)
        {
            return _context.Ansatt.Any(e => e.ID == id);
        }
    }
}
