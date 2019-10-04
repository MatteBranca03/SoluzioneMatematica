using LibreriaMatematica;
using System;

namespace Matematica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il primo numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("che operazione vuoi fare? Somma / Sottrazione / Moltiplicazione / Divisione / Massimo / Minimo / Potenza");
            string ris= Console.ReadLine();
            double risultato = 0;
            switch (ris)
            {
                case "Somma":
                    risultato = Operazioni.Somma(n1, n2);
                    break;
                case "Prodotto":
                    risultato = Operazioni.Prodotto(n1, n2);
                    break;
                case "Differenza":
                    risultato = Operazioni.Differenza(n1, n2);
                    break;
                case "Divisione":
                    risultato = Operazioni.Divisione(n1, n2);
                    break;
                case "Massimo":
                    risultato = Operazioni.Massimo(n1, n2);
                    break;
                case "Minimo":
                    risultato = Operazioni.Minimo(n1, n2);
                    break;
                case "Potenza":
                    risultato = Operazioni.Potenza(n1, n2);
                    break;
                default:
                    throw new Exception(" scelta non valida");
            }
            Console.WriteLine($"{risultato}");
            Console.ReadLine();
            }
        }
    }

