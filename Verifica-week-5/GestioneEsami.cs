using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_week_5
{
    public static class GestioneEsami
    {
        public static List<Corso> corsi = new List<Corso>();
        

        public static List<Corso> GetCorsi(CorsoDiLaurea corsoDiLaurea)
        {
            if (corsoDiLaurea.Nome == (CorsiDiLaurea)0)
            {
                Corso c1 = new Corso("Algebra", 10);
                Corso c2 = new Corso("Geometria", 5);

                corsi.Add(c1);
                corsi.Add(c2);

            }


            if (corsoDiLaurea.Nome == (CorsiDiLaurea)1)
            {
                Corso c1 = new Corso("Fisica quantistica", 20);
                Corso c2 = new Corso("Astronomia", 15);

                corsi.Add(c1);
                corsi.Add(c2);

            }

            if (corsoDiLaurea.Nome == (CorsiDiLaurea)2)
            {
                Corso c1 = new Corso("Storia dell'informatica", 5);
                Corso c2 = new Corso("Programmazione", 15);

                corsi.Add(c1);
                corsi.Add(c2);

            }
            if (corsoDiLaurea.Nome == (CorsiDiLaurea)3)
            {
                Corso c1 = new Corso("Ingegneria civile", 8);
                Corso c2 = new Corso("Ingegneria ambientale", 18);

                corsi.Add(c1);
                corsi.Add(c2);

            }

            if (corsoDiLaurea.Nome == (CorsiDiLaurea)3)
            {
                Corso c1 = new Corso("Storia della letteratura", 7);
                Corso c2 = new Corso("Filosofia", 15);

                corsi.Add(c1);
                corsi.Add(c2);

            }
            return corsi;
        }
    }
}
