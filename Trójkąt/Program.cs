using System;
using System.Globalization;
//Napisz program, który ze standardowego wejścia wczyta trzy liczby określające długości boków pewnego trójkąta. Liczby te są podane w postaci zmiennoprzecinkowej, z dokładnością do dwóch miejsc po przecinku, w jednej linii, oddzielone średnikiem i jedną spacją. Liczby podane są w formacie "en-US" (z kropką dziesiętną).
namespace Trójkąt
{
    class Program
    {

        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            string wejscie = Console.ReadLine();
            string[] podzial = wejscie.Split("; ");
            double a = Convert.ToDouble(podzial[0]);
            double b = Convert.ToDouble(podzial[1]);
            double c = Convert.ToDouble(podzial[2]);
            /*Jeśli którakolwiek z podanych liczb jest niedodatnia, wypisz komunikat Błędne dane. Długości boków muszą być dodatnie! i przerwij działanie programu. */
            double[] listaBokow = { a, b, c };
            foreach (double number in listaBokow)
            {
                if (number < 0)
                {
                    Console.WriteLine("Długości boków muszą być dodatnie!");
                   return;
                    
                }
            }
            ////Jeśli z podanych długości boków nie można zbudować trójkąta, wypisz komunikat: Błędne dane. Trójkąta nie można zbudować!i przerwij działanie programu. (UWAGA: dopuszczamy trójkąt, którego boki się pokrywają, o polu zerowym).
            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                Console.WriteLine("Błędne dane. Trójkąta nie można zbudować!");
                return;
               
            }
            double obwod = a + b + c;
            double p = obwod / 2;
            double dopola = p * ((p - a)*(p - b)*(p - c));
            double pole = Math.Sqrt(dopola);
            double a2 = a * a;
            double b2 = b * b;
            double c2 = c * c;
            double nr1 = a2 + b2;
            string typ;

            static string GetTyp(double nr1, double c2)
            {
          
                string n = "";
                if (nr1 == c2) { n = "prostokątny"; }
                else if (nr1 < c2) { n = "rozwartokątny"; }
                else if (nr1 > c2) { n = "ostrokątny"; }
                return n;
            }
           typ=  GetTyp(nr1, c2);


            //                a2 + b2 = c2 - trójkąt prostokątny
            //a2 + b2 < c2 - trójkąt rozwartokątny
            //a2 + b2 > c2 - trójkąt ostrokątny

            Console.WriteLine("obwód = {0:F2}", obwod);
            Console.WriteLine("pole = {0:F2}", pole);
            Console.WriteLine("trójkąt jest {0}", typ);
            if (a==b&& b==c) { Console.WriteLine("trójkąt jest równoboczny"); }
            else if (a==b || b==c ||a==c) { Console.WriteLine("trójkąt jest równoramienny"); }

            //W ostatniej linii, jeśli trójkąt jest równoboczny, wypisz komunikat trójkąt równoboczny, zaś jeśli jest równoramienny, wypisz komunikat trójkąt równoramienny.

         
        }
    }
}
