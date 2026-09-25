using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileMethodes
{
    internal class Program
    {

        static void Koszon()
        {
            Console.WriteLine("Szia!");
        }
        
        static void Koszon(string nev)
        {
            Console.WriteLine($"Szia {nev}!");
        }

        static void Bemutatkozas(string nev, int eletkor)
        {
            Console.WriteLine($"Szia {nev}!");
            Console.WriteLine($"A te életkorod: {eletkor}");
        }

        static int Osszeg(int szam1, int szam2)
        {
            int osszeg = szam1 + szam2;
            return osszeg;

            //return szam1 + szam2; // rövidebb verzió
        }

        static long Osszeadas(long szam1, long szam2)
        {
            return szam1 + szam2;
        }
        static long Kivonas(long szam1, long szam2)
        {
            if (szam1 > szam2)
            {
                return szam1 - szam2;
            }
            else
            {
                return szam2 - szam1;
            }
            
        }
        static long Szorzas(long szam1, long szam2)
        {
            return szam1 * szam2;
        }
        static double Osztas(double szam1, double szam2)
        {
            return szam1 / szam2;
        }

        static void Koszones(string nev = "Vendég")
        {
            Console.WriteLine($"Szia {nev}");
        }

        static bool NagykoruE(int kor)
        {
            /*
            if (kor >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
            */
            return kor >= 18; // rövidebb verzió

        }
            static void Main(string[] args)
        {
            //var nev = "Józsi";
            ////Koszones(nev, 12);
            //Koszones();
            /*
            Koszon();

            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine();
            //Koszon(nev);
            Console.Write("Add meg az életkorod: ");
            int kor = Convert.ToInt32(Console.ReadLine());
            Bemutatkozas(nev, kor);

            int osszeg = Osszeg(2, 5);
            Console.WriteLine(osszeg);
            Console.WriteLine(Osszeg(2,5));
            */

            //Console.Write("Kérem az első számot: ");
            //long szam1 = long.Parse(Console.ReadLine());
            //Console.Write("Második szám: ");
            //long szam2 = long.Parse(Console.ReadLine());

            //Console.WriteLine($"Összeadás: {Osszeadas(szam1, szam2)}");
            //Console.WriteLine($"Kivonas: {Kivonas(szam1, szam2)}");
            //Console.WriteLine($"Szorzas: {Szorzas(szam1, szam2)}");
            //Console.WriteLine($"Osztas: {Osztas(szam1, szam2)}");

            //string nagykoruE = "";
            //if (NagykoruE(19))
            //{
            //    nagykoruE = "Nagy korú";
            //}
            //else
            //{
            //    nagykoruE = "Kis korú";
            //}


            //// ? true ág : else ág
            //nagykoruE = NagykoruE(19) ? "Nagy korú" : "Kiskorú";


            //Console.WriteLine($"A te életszakaszod: {NagykoruE(19)}");
            //Console.WriteLine($"A te életszakaszod: {nagykoruE}");


            int szam = 1;
            do
            {
                Console.WriteLine(szam);
                //szam = szam + 1;
                //szam += 1;
                //szam++;
                //szam = szam - 1;
                //szam--;

                szam++;
            } while (szam <= 5);



            int valasztas;

            do
            {
                Console.Clear();
                Console.WriteLine("===MEBÜ===");
                Console.WriteLine("1.) Köszönés");
                Console.WriteLine("2.) Név bekérés");
                Console.WriteLine("3.) Kilépés");
                Console.Write("Választás: ");
                valasztas = Convert.ToInt32(Console.ReadLine());
                
                switch (valasztas) 
                {
                    case 1:
                        Koszones();
                        //Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Mi a neved?");
                        string nev = Console.ReadLine();
                        Console.WriteLine($"Szia {nev}!");
                        //Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Kilépés....");
                        //Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Nincs ilyen menüpont");
                        //Console.ReadLine();
                        break;
                    

                }

                Console.ReadLine();
            } while (valasztas != 3);


            


            Console.ReadLine();
        }
    }
}
