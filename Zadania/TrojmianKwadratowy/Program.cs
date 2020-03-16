using System;

namespace trojmianKwadratowy
{
    class Program
    {
        static void Main(string[] args)
        {
            TrojmianKwadratowy();
            Console.ReadKey();
        }
        //Zadanie 3 - trójmian kwadratowy - Metoda
        public static void TrojmianKwadratowy()
        {

            double a, b, c;

            Console.WriteLine("Wprowadz wartosc a ");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadz wartosc b ");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadz wartosc c ");
            c = Double.Parse(Console.ReadLine());

            //double Delta = Math.Pow(double b, double 2)

            double delta = (b * b) - 4 * (a * c);


            if (delta < 0)

            {
                Console.WriteLine("Rownianie nie ma rozwiązania, podaj nowe a,b,c");

            }

            else if (delta > 0)
            {

                Console.WriteLine("Równianie ma dwa rozwiązania: x1, x2");
               double x1 = (-b) - (Math.Sqrt(delta) / 2 * a);
               double  x2 = (-b) + (Math.Sqrt(delta) / 2 * a);

                Console.WriteLine($"Wynik" + x1); //lub return x1
                Console.WriteLine($"Wynik" + x2);
                
            }

            if (delta == 0)
            {
                Console.WriteLine(" Równanie ma jedno rozwiązanie");
                double x3 = (-b) / 2 * a;
                
                    Console.WriteLine($"Wynik" + x3);
                
             
                    

            } 
        }


    }
}
