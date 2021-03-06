using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VismaE2interRPWDWEDN.Data;
using VismaE2interRPWDWEDN.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VismaE2interRPWDWEDN.Pages.Ansatte
{
    public class IndexModel : PageModel
    {
        private readonly VismaE2interRPWDWEDN.Data.VismaE2interRPWDWEDNContext _context;

        public IndexModel(VismaE2interRPWDWEDN.Data.VismaE2interRPWDWEDNContext context)
        {
            _context = context;
        }

        public IList<Ansatt> Ansatt { get; set; }
        public IList<Ansatt> AnsattSearch { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }



        public async Task OnGetAsync()
        {
            Ansatt = await _context.Ansatt.AsNoTracking().ToListAsync();

            var ansatt = from a in _context.Ansatt
                             select a;
          
            if (!string.IsNullOrEmpty(SearchString))
            {
                ansatt = ansatt.Where(s => s.Name.Contains(SearchString));
            } 

            AnsattSearch = await ansatt.ToListAsync();

        }
    }
}
