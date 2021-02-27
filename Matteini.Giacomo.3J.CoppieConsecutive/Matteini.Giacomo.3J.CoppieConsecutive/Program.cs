using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteini.Giacomo._3J.CoppieConsecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            string StrnN = "", StrnContacoppie ="";
            int n = 0, i = 0, contacoppie = 0;


            //INPUT LUNGHEZZA VETTORE
            Console.WriteLine("inserisci la lunghezza del vettore");
            StrnN = Console.ReadLine();
            n = Convert.ToInt32(StrnN);


            //CREAZIONE ARRAY 1
            int[] array = new int[n];


            //CARICA ARRAY 1

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Inserisci un numero");
                StrnN = Console.ReadLine();
                array[i] = Convert.ToInt32(StrnN);
            }

            //COMPARE AND OUTPUT
                
            for (i = 0; i < (n-1); i++)
            {
                if (array[i+1] == array[i]+1)
                    contacoppie++;
            
            }
            StrnContacoppie = Convert.ToString(contacoppie);
            Console.WriteLine("Nell'array ci sono " + StrnContacoppie + " Coppie di numeri consecutivi");
            Console.ReadLine();
        }
    }
}
