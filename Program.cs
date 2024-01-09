using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljanje
{
    internal class Program
    {
        public class Neboder
        {
            private string a_vrsta;
            public string vrsta
            {
                get { return a_vrsta; }
                set { a_vrsta = value; }

            }
            private double a_max_brzina;
            public double max_brzina
            {
                get { return a_max_brzina; }
                set { if (a_vrsta == "Automobil")
                    {
                        a_max_brzina = value + (value * 0.3);
                    }
                    else { a_max_brzina = value;}
                }
            }
            private int a_broj_kotaca;
            public int broj_kotaca
            {
                get { return a_broj_kotaca; }
                set { a_broj_kotaca = value; }
            }
            

            public void ispis()
            {
                Console.WriteLine("Vrsta: {0}\nMax brzina: {1}\nBroj kotaca: {2}", a_vrsta, a_max_brzina, a_broj_kotaca);
            }
        }

        static void Main(string[] args)
        {
            Neboder a = new Neboder();
            a.ispis();
            a.vrsta = "Motocikl";
            a.max_brzina = 140;
            a.broj_kotaca = 2;
            a.ispis();
            a.vrsta = "Automobil";
            a.max_brzina = 140;
            a.broj_kotaca += 2;
            a.ispis();

            Console.ReadKey();
        }
    }
}
