using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VismaE2interRPWDWEDN.Models;

namespace VismaE2interRPWDWEDN.Data
{
    public class VismaE2interRPWDWEDNContext : DbContext
    {
        public VismaE2interRPWDWEDNContext (DbContextOptions<VismaE2interRPWDWEDNContext> options)
            : base(options)
        {
        }

        public DbSet<VismaE2interRPWDWEDN.Models.Ansatt> Ansatt { get; set; }

        public DbSet<VismaE2interRPWDWEDN.Models.Stilling> Stilling { get; set; }
    }
}
