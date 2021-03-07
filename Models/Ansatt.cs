using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace VismaE2interRPWDWEDN.Models
{
    public class Ansatt
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Stilling { get; set; }
        public string Oppgave { get; set; }

        [Column(TypeName = "Date")]
        public DateTime PositionStartDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime PositionEndDate { get; set; }

    }
}
