using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._2
{
    internal class Banca
    {
        public string Nome { get; set; }
        public List<Cliente> Clienti { get; set; }
        public List<PrestitoConcesso> Prestiti { get; set; }

        public void AddPrestito(PrestitoConcesso prestito)
        {
            this.Prestiti.Add(prestito);
        }
        public void AddCliente(Cliente cliente)
        {
            this.Clienti.Add(cliente);
        }
        public void RemoveCliente(Cliente cliente)
        {
            this.Clienti.Remove(cliente);
        }

    }
}
