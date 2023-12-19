using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._2
{
    internal class PrestitoConcesso
    {
        public Cliente Intestatario { get; set; }
        public double Ammontare { get; set; }
        public double Rata { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
    }
}
