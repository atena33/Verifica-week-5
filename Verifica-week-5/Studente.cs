using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_week_5
{
    public class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; }
        public Immatricolazione Immatricolazione { get; set; } = new Immatricolazione();
        public List<Esame> Esami { get; set; } = new List<Esame>();
        public bool RichiestaLaurea { get { return GetRichiestaLurea(); }  }

        public Studente()
        {

        }
        public Studente(string nome, string cognome,  Immatricolazione immatricolazione)

        {
            Nome = nome;
            Cognome = cognome;
            Immatricolazione = immatricolazione;
        }

        public bool GetRichiestaLurea()
        {

            foreach (var item in Esami)
            {
                int somma = 0; ;
                somma += item.Corso.CFU;
                if (CorsoDiLaurea.CFUTotali == somma)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
