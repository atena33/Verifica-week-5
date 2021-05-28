using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_week_5
{
    public class Immatricolazione
    {
        public static int codicePartenza = 100; //Campo statico per creare l'id

        public int Matricola { get; }
        public DateTime DataInizio { get; set; }
        public CorsoDiLaurea CorsoDiLaurea { get; set; } = new CorsoDiLaurea();
        public bool FuoriCorso { get; set; }
        public int CFUAccumulati { get; set; }

        public Immatricolazione(CorsiDiLaurea corsiDiLaurea)
        {

        }
        public Immatricolazione( CorsiDiLaurea corsoDiLaurea, bool fuoriCorso, int cFUAccumulati)
        {
            CorsoDiLaurea = CorsoDiLaurea;
            FuoriCorso = fuoriCorso;
            CFUAccumulati = cFUAccumulati;
            Matricola = codicePartenza++;


        }
        public Immatricolazione()
        {

        }

        public int GeneraMatricola()
        {
            int matricola = 100;
           return  matricola++;
        }
    }
}
