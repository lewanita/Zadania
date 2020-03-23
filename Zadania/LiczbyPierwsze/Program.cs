using System;

namespace LiczbyPierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LiczbyPierwsze z uzyciem if  

            Console.WriteLine("Podaj liczbe pierwsza :");
            var liczbaPierwszaText = Console.ReadLine(); 
            int parsedText;
            var parseResult = int.TryParse(liczbaPierwszaText, out parsedText);

            if (parseResult)
            {

                Console.WriteLine("wprowadziłes liczbe");
                if (parsedText % 2 == 0 || parsedText % 3 == 0 || parsedText % 5 == 0)
                {
                   
                    Console.WriteLine("To nie jest liczba pierwsza");
                }
                else
                    Console.WriteLine("To jest liczba pierwsza");

            }
            else
            {
                Console.WriteLine("to nie jest liczba");
            }
            Console.ReadLine();
            #endregion



            #region LiczbyPierwsze w petli while
            //bool endLoop = true;
            //int i=1;


            //while ( endLoop) 
            //{
            //    i += 1; // i=i+1 = i++
            //    Console.WriteLine("Enter a number:");
            //    var UserNumber = Console.ReadLine(); 

            //    if (UserNumber== "q") 
            //    {
            //        endLoop = false;
            //        continue; // program zacznie od nowa petle == nowa iteracja petli 
            //    }
            //    int FirstNumber;
            //    var Result = int.TryParse(UserNumber, out FirstNumber);



            //    if (FirstNumber==2||FirstNumber==3 || FirstNumber==5) 
            //    {
            //        Console.WriteLine("To jest liczba pierwsza");
            //    }

            //    else if (FirstNumber % 2 == 0 || FirstNumber % 3 == 0 || FirstNumber % 5 == 0) 
            //    {

            //        Console.WriteLine(" To nie jest liczba pierwsza");
            //    } else 
            //    {
            //        Console.WriteLine("To jest liczba pierwsza");
            //    }




            //}
            //Console.WriteLine("Koniec");
            //Console.ReadLine();
            #endregion


        }

    }
}
