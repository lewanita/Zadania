using System;

namespace ŚredniaArytmetycznaMetody
{
    class Program
    {
        static void Main(string[] args)
        {
            SredniaArytmetycznaUser();
            Console.ReadLine();
            
           /* int result =SrdniaArytmetyczna(3,4);
            Console.WriteLine(result);

            Console.ReadLine();*/
        }
        /*public static int SrdniaArytmetyczna(int x, int y) 
        {
            int wynik;
            wynik = x + y / 2;
            Console.WriteLine(wynik);
            Console.ReadLine();
            return wynik;
        }*/
        public static void SredniaArytmetycznaUser() 
        {
            Console.WriteLine("Podaj ilość wprowadzanych liczb");
            int IloscLiczb = int.Parse(Console.ReadLine());
            double wynik=0;

            for (int i =1;i<=IloscLiczb;i++) 
            {
                Console.WriteLine("Podaj liczbe:");
                int UserNumber = int.Parse(Console.ReadLine());
                wynik = wynik + UserNumber; 
                //wynik += UserNumber;

                
            }
           
            wynik = wynik/ IloscLiczb;
            Console.WriteLine($"Wynik: {wynik}");
            Console.ReadLine();

                
                                   
                   

                
       
            
        }


    }
}
