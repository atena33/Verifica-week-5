using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_week_5
{
    public class CorsoDiLaurea
    {
        public CorsiDiLaurea Nome { get; set; }
        public int AnniDiCorso { get; set; } = 5;
        public static int CFUTotali { get { return GetCfuTotali(); }  }

        public CorsoDiLaurea()
        {

        }
        

        public static int GetCfuTotali()
        {
            int tot = 0;
            foreach (var item in GestioneEsami.corsi)
            {
                tot += item.CFU;
            }

            return tot;
        }
    }
}
public enum CorsiDiLaurea
{
    Matematica,
    Fisica,
    Informatica,
    Ingegneria,
    Lettere

}