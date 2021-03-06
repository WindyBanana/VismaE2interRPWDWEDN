using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VismaE2interRPWDWEDN.Data;
using VismaE2interRPWDWEDN.Models;
using Microsoft.EntityFrameworkCore;

namespace VismaE2interRPWDWEDN.Pages.Ansatte
{
    public class CreateModel : PageModel
    {
        private readonly VismaE2interRPWDWEDN.Data.VismaE2interRPWDWEDNContext _context;

        public CreateModel(VismaE2interRPWDWEDN.Data.VismaE2interRPWDWEDNContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            IQueryable<string> stillingQuery = from s in _context.Stilling
                                               orderby s.Name
                                               select s.Name;
            Stillinger = new SelectList(await stillingQuery.ToListAsync());
            
            return Page();
        }

        [BindProperty]
        public Ansatt Ansatt { get; set; }

        public SelectList Stillinger { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Ansatt.Add(Ansatt);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
