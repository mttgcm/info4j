using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matteini.Giacomo._4J.GiocoDiCarte
{
    class Program
    {
        static void Main(string[] args)
        {
            string Strn = "", seme = "";
            int Ncarta = 0;

            Carta carta1 = new Carta();
            Carta carta2 = new Carta();


            //INPUT PRIMA CARTA
            //valore
            Console.WriteLine();
            Console.WriteLine("INSERISCI IL VALORE DELLA PRIMA CARTA.");
            Console.WriteLine("Valori consentiti: 2 - 10 per le carte con il numero riportato agli angoli. 11 - 14 per il Jack, Queen, King e Ace");
            Strn = Console.ReadLine();
            Ncarta = Convert.ToInt32(Strn);
            carta1.Numero = Ncarta;
            //seme
            Console.WriteLine("INSERISCI IL SEME DELLA PRIMA CARTA.");
            Console.WriteLine("Valori consentiti: C (cuori), Q (quadri), F (fiori), P (picche)");
            seme = Console.ReadLine();
            carta1.Seme = seme;


            //Reimposto variabili
            Strn = "";
            seme = "";
            Ncarta = 0;


            //INPUT SECONDA CARTA
            //valore
            Console.WriteLine("INSERISCI IL VALORE DELLA SEOCNDA CARTA.");
            Console.WriteLine("Valori consentiti: 2 - 10 per le carte con il numero riportato agli angoli. 11 - 14 per il Jack, Queen, King e Ace");
            Strn = Console.ReadLine();
            Ncarta = Convert.ToInt32(Strn);
            carta2.Numero = Ncarta;
            //seme
            Console.WriteLine("INSERISCI IL SEME DELLA SEOCNDA CARTA.");
            Console.WriteLine("Valori consentiti: C (cuori), Q (quadri), F (fiori), P (picche)");
            seme = Console.ReadLine();
            carta2.Seme = seme;



            Console.WriteLine();
            Console.WriteLine();

            if(carta1.Vince(carta2)==1)
            {
                Console.WriteLine("Il " + carta1.Visualizza() + " vince sul " + carta2.Visualizza());
            }
            else if (carta1.Vince(carta2) == 0)
            {
                Console.WriteLine("Il " + carta1.Visualizza() + " vince sul " + carta2.Visualizza() + " con pareggio di valore");
            }
            else if(carta1.Vince(carta2) == 2)
            {
                Console.WriteLine("Il " + carta2.Visualizza() +" vince sul " + carta1.Visualizza());
            }

            Console.ReadLine();
        }
    }
    class Carta
    {
        private int numero;
        private string seme;
        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                if(value < 2 || value > 14)
                {
                    numero = 2;
                }
                else
                {
                    numero = value;
                }
            }
        }
        public string Seme
        {
            get
            {
                return seme;
            }
            set
            {
                if (value != "C" && value != "Q" && value != "F" && value != "P")
                {
                    seme = "P";
                }
                else
                {
                    seme = value;
                }
            }
        }
       
        //COSTRUTTORE STANDARD
        public Carta()
        {
            numero = 0;
            seme = "";
        }

        public string Visualizza()
        {

            string strnGigi = "", strnSeme="", strnTipo="";

            if(seme=="C")
            {
                strnSeme = "Cuori";
            }
            else if (seme == "Q")
            {
                strnSeme = "Quadri";
            }
            else if (seme == "F")
            {
                strnSeme = "Fiori";
            }
            else if (seme == "P")
            {
                strnSeme = "Picche";
            }

            if(numero==11)
            {
                strnTipo="Jack (fante)";
            }
            else if (numero == 12)
            {
                strnTipo = "Queen (regina)";
            }
            else if (numero == 13)
            {
                strnTipo = "King (re)";
            }
            else if (numero == 14)
            {
                strnTipo = "Ace (asso)";
            }
            else
            {
                strnTipo = Convert.ToString(numero);
            }
            
            return strnGigi = strnTipo + " di " + strnSeme;

        }
        public int Vince(Carta carta2)
        {
            int gigi = 0;
            if(numero>carta2.numero)
            {
                gigi = 1;
            }
            else if(numero==carta2.numero)
            {
                gigi = 0;
            }
            else
            {
                gigi = 2;
            }
            return gigi;
        }


    }
}
