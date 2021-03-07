using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VismaE2interRPWDWEDN.Data;
using VismaE2interRPWDWEDN.Models;

namespace VismaE2interRPWDWEDN.Pages.Ansatte
{
    public class DetailsModel : PageModel
    {
        private readonly VismaE2interRPWDWEDN.Data.VismaE2interRPWDWEDNContext _context;

        public DetailsModel(VismaE2interRPWDWEDN.Data.VismaE2interRPWDWEDNContext context)
        {
            _context = context;
        }

        public Ansatt Ansatt { get; set; }
        public Stilling Stilling { get; set; }

        public Stilling PositionStartDate { get; set; }
        public Stilling PositionEndDate { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ansatt = await _context.Ansatt.FirstOrDefaultAsync(m => m.ID == id);

            if (Ansatt == null)
            {
                return NotFound();
            }

           Stilling = await _context.Stilling.FirstOrDefaultAsync(s => s.ID == id);
     //      PositionStartDate = await _context.Stilling.FirstOrDefaultAsync(a => a.PositionStartDate == s.ID);
            /*
            if (Stilling == null)
            {
                return NotFound();
            }
            */
            return Page();
        }
    }
}
