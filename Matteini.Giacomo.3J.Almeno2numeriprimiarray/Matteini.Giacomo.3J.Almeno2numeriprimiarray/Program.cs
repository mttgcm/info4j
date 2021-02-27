using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteini.Giacomo._3J.Almeno2numeriprimiarray
{
    class Program
    {
        static void Main(string[] args)
        {

            string numero = "";
            int n = 0, grandezza = 0, i = 0, contTrue = 0;

            //ARRAY
            Console.WriteLine("inserisci la lunghezza del vettore");
            numero = Console.ReadLine();
            grandezza = Convert.ToInt32(numero);
            int[] array = new int[grandezza];


            //CARICA ARRAY
            for (i = 0; i < grandezza; i++)
            {
                Console.WriteLine("Inserisci un numero");
                numero = Console.ReadLine();
                n = Convert.ToInt32(numero);
                array[i]=n;
            }


            //VERIFICA SE VALORI PRIMI (RICHIAMO A FX)
            for (i = 0; i < grandezza; i++)
            {
                if (NumeroPrimo(array[i]))
                {
                    contTrue++;
                }
            }
            //Console.WriteLine(contTrue);

            if (contTrue>=2)
            {
                Console.WriteLine("nel vettore ci sono almeno 2 numeri primi");
            }
            else
            {
                Console.WriteLine("nel vettore non ci sono almeno 2 numeri primi");
            }
            Console.ReadLine();
        }



        //FX VERIFICA SE PRIMO
        static bool NumeroPrimo(int x)
        {

            for (int i = 2; i < x/2; ++i)
                if (x % i == 0)
                    return false;
            return true;
        }
    }
}
