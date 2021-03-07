using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VismaE2interRPWDWEDN.Models
{
    public class Stilling
    {
        public int ID { get; set; }
        public string Name {get; set; }

        [DataType(DataType.Date)]
        public DateTime PositionStartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime PositionEndDate { get; set; }
        public string Ansatt { get; set; }


}
}
