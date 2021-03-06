using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace VismaE2interRPWDWEDN.Models
{
    public class Oppgave
    {
        public int ID { get; set; }
        public string Oppgavetittel { get; set; }
        [Column(TypeName = "Date")]
        public DateTime OppgaveDato { get; set; }

        public string Stilling { get; set; }
        public string Ansatt { get; set; }
    }
}
