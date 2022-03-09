using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Lectia1
{
    public class Lectia1
    {
        public static void Run() 
        {
            //Modifica Functia Run()
            //sa citeasca de la tastatura 2 valori: 1 nume, 1 prenume.
            //Si apoi, folosind GetFullName(), returneaza numele complet, format din cele doua valori unite
            //_citeste de la tastatura valori aici_

            //ex:
            //Console.WriteLine(GetFullName("Ana", "Pop")); // -> "AnaPop"
            //Console.WriteLine(GetFullName("William", "X")); // -> "WilliamX"


            //Modifica functia AriaCerc()
            //sa calculeaze aria unui cerc, pt o raza data ca parametru
            //Console.WriteLine("Aria Cerc cu raza 2.5:" + AriaCerc(2.5)); //->19.625

            //Modifica functia Wacky()
            //sa calculeze pt doua numere date x si y, valoarea: (x+1) * (y-1)
            //folosind operatorii de incrementare si decrementare
            //Console.WriteLine(Wacky(8, 3)); // -> 18

            //Modifica functia Bisect()
            //sa returneze daca un an dat ca parametru este bisect : true/false
            //Mod de calcul:
            //To be a leap year, the year number must be divisible by four – except for end-of-century years,
            //which must be divisible by 400.
            //This means that the year 2000 was a leap year, although 1900 was not. 2020, 2024 and 2028 are all leap years.
            //Console.WriteLine(Bisect(2000)); // -> true
            //Console.WriteLine(Bisect(2001)); // -> false
            //Console.WriteLine(Bisect(1900)); // -> false
            //Console.WriteLine(Bisect(2016)); // -> true

            //Modifica functia GetUSGrade()
            //Sa calculeze nota in sistemul American de notare.
            //Primeste un parametru o nota de la 1-10 (numar intreg, fara fractiuni).
            //Returneaza nota echivalenta in sistem US. Presupunem urmatoarele reguli:
            //10 = A
            //9 sau 8 = B
            //7 = C
            //6 sau 5 = D
            //4 sau mai putin = F
            //Console.WriteLine(GetUSGrade(10)); // -> A
            //Console.WriteLine(GetUSGrade(5)); // -> D
            //Console.WriteLine(GetUSGrade(8)); // -> B
        }


        public static string GetFullName(string x, string y) 
        {
            //Modifica Functia GetFullName() astfel incat sa primeasca 2 parametri de tip string,
            //si sa returneze valoarea string formata din concatenarea/unirea valorilor celor 2 parametri.
            return "";
        }

        public static double AriaCerc(double raza) 
        {
            return 1;
        }

        public static int Wacky(int x, int y) 
        {
            return 1;
        }

        public static bool Bisect(int year) 
        {
            return false;
        }

        public static string GetUSGrade(int grade) 
        {
            return "X";
        }

    }
}
