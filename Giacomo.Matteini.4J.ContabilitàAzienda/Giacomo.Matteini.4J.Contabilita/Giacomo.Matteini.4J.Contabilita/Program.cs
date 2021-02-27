using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giacomo.Matteini._4J.Contabilita
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dato un piccolo archivio di dipendenti , consentire al ragioniere di sapere quante ore di straordinario ha fatto il dipendente X e anche quante ore di straordinario hanno fatto complessivamente i dipendenti del reparto Y.

            //VARIABILI
            string strnCognome, strnReparto;
            int i = 0, totOre = 0;
            string[] arrayCognome = {"rossotti",  "neretti",             "bianchi",          "verdelli",             "rosati",                "violaceo",             "giallini",    "grigiastri",    "bronzati",    "dell'azzurra"};
            string[] arrayReparto = {"direttore", "consulente privato", "consulente privato", "consulente privato", "consulente aziendale", "consulente aziendale",   "cassiere",    "cassiere",      "cassiere",    "pulizia"};
            int[] arrayOreStraordinari = {6,         3,                      6,                   9,                     1,                      8,                      2,              6,              7,              13};


            //RICERCA PER COGNOME
            Console.WriteLine("Inserisci il cognome di un dipendente per vedere le relative ore di straordinari");
            strnCognome = Console.ReadLine();

            for (i = 0; i < arrayCognome.Length; i++)
            {
                if (strnCognome==arrayCognome[i])
                {
                    Console.WriteLine("Il dipendente " + arrayCognome[i] + " del reparto " + arrayReparto[i] +"ed ha totalizzato " + arrayOreStraordinari[i] + " ore");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            //RICERCA PER REPARTO
            Console.WriteLine("Inserisci il reparto per vedere le relative ore di straordinari");
            strnReparto = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine();

            //conta ore
            for (i = 0; i < arrayCognome.Length; i++)
            {
                if (strnReparto == arrayReparto[i])
                {
                    totOre = totOre + arrayOreStraordinari[i];
                }
            }

            Console.WriteLine("Il reparto " + strnReparto + " ha totalizzato " + totOre + " ore");
            
            Console.ReadLine();
        }
    }
}
