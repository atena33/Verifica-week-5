using System;
using System.Collections.Generic;

//Risposta 1

//a, b, c

//Risposta 2

//Le variabili di tipo string vengono memorizzate nella memoria____heap___ perché sono ____references______ Type. 

//Risposta 3

//d


namespace Verifica_week_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Immatricolazione i1 = new Immatricolazione((CorsiDiLaurea)0, false, 0);
            Immatricolazione i2 = new Immatricolazione((CorsiDiLaurea)1, true, 0);
            Immatricolazione i3 = new Immatricolazione((CorsiDiLaurea)2, false, 0);
            Immatricolazione i4 = new Immatricolazione((CorsiDiLaurea)3, true, 0);
            Immatricolazione i5 = new Immatricolazione((CorsiDiLaurea)4, false, 0);
            Studente s1 = new Studente("Mario", "Rossi", i1);
            Studente s2 = new Studente("Mauro", "Bianchi", i2);
            Studente s3 = new Studente("Andrea", "Neri", i3);
            Studente s4 = new Studente("Giacomo", "Bianchi", i4);
            Studente s5 = new Studente("Katia", "Verdi", i2);

            var studenti = new List<Studente>();
            studenti.Add(s1);
            studenti.Add(s2);
            studenti.Add(s3);
            studenti.Add(s4);
            studenti.Add(s5);

            Console.WriteLine("Benvenuto! Inserisci il tuo nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome");
            string cognome = Console.ReadLine();

            foreach (var item in studenti)
            {
                if (item.Nome == nome && item.Cognome == cognome)
                {
                    
                    do
                    {
                        Console.WriteLine($"Benvenuto {nome} {cognome} Fai la tua scelta");
                        Console.WriteLine(" Scegli 1 per prenotare un esame");
                        Console.WriteLine("Scegli 2 per verbalizzare un esame");
                        Console.WriteLine("Scegli 0 per uscire");
                        int scelta = int.Parse(Console.ReadLine());

                        switch (scelta)
                        {
                            case 1:
                                foreach (Corso corso in GestioneEsami.corsi)
                                {
                                    Console.WriteLine($"{ corso}");
                                }
                                break;
                            case 2:
                                break;
                            case 0:
                                return;
                            default:
                                Console.WriteLine("Scelta errata");
                                break;
                        }

                    } while (true);

                }
            }










        }
    }
}
