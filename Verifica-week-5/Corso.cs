using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_week_5
{
    public class Corso
    {
        public string Nome { get; set; }
        public int CFU { get; set; }

        public Corso()
        {

        }

        public Corso(string nome, int cFU)
        {
            Nome = nome;
            CFU = cFU;
        }
    }
}
