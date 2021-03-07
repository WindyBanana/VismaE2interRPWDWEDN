using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VismaE2interRPWDWEDN.Models
{
    public class ViewWDW
    {
        public int ID { get; set; }
        public Ansatt GetAnsatt { get; set; }
        public Stilling GetStilling { get; set; }
        public Stilling GetStartDate { get; set; }
        public Stilling GetEndDate { get; set; }
        public Oppgave GetOppgave { get; set; }

    }
}
