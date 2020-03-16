using System;

namespace TrójkaPitagorejska
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trójka pitagorejska = a2+b2=c2
            //Console.WriteLine(IsItPitagoras());
            //Console.ReadLine();
            //Console.WriteLine(Hypotenuse());
            //Console.ReadLine();

            double a, b, c;
            Console.WriteLine("Enter a value a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a value c: ");
            c = double.Parse(Console.ReadLine());


            bool result = IsItPitagoras(a,b,c);

            Console.WriteLine(result);

            if (result)
            {
                Console.WriteLine("To jest trojkat pitagorejski");

            }
            else
                Console.WriteLine("To nie jest trojkat pitagorejski. Wrtosc c musi wynosić" + Hypotenuse(a,b));
              
        }
        public static bool IsItPitagoras(double a, double b, double c)
        {
            //double a, b, c;
            //Console.WriteLine("Enter a value a: ");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a value b: ");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a value c: ");
            //c = double.Parse(Console.ReadLine());

            bool IsItPitagoras = (a * a) + (b * b) == c * c;

            return IsItPitagoras;

          
            
            //if (IsItPitagoras) 
            //     {
            //         return true;
            //     }
            //return false;


           

        }
        public static double Hypotenuse(double a,double b) // przeciwprostokatna
        {
            //Console.WriteLine("Enter a value:");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter b value:");
            //double b = double.Parse(Console.ReadLine());
            
            double c = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine($"Wynik {c}");
            return c;
            
              
                
            
        
        }


    }
}
