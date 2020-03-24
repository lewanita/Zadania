using System;

namespace Petle_ćwiczenia
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Wypisz liczby od 1 do 100
            //for(int i = 1; i < 100; i++) 
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();
            #endregion

            #region Wypisz liczby parzyste od 2 do 50

            //var czyParzysta = true;

            //if(czyParzysta) 
            //{
            //    for (int i = 2; i < 50; i++)
            //    {
            //        if (i % 2 == 0 && i % 4 == 0) 
            //        {
            //            Console.WriteLine(i);
            //            czyParzysta = false;
            //        }

            //    }   
            //}
            //Console.ReadLine();
            #endregion

            #region Wypisz liczby od 100 do 1

            //for(int i = 100; i>=1;i--) 
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Wypisz liczby podzielne przez 8 w zakresie 1 do 100

            //bool czyPodzielna = true;
            //if (czyPodzielna) 
            //{
            //for(int i = 1; i < 100; i++) 
            //    {
            //        if (i % 8 == 0) 
            //        {
            //            Console.WriteLine(i);
            //            czyPodzielna = false;
            //        }

            //    }
            //    Console.ReadLine();
            //}
            #endregion

            #region Wypisz najwieksza liczb niepodzielną przez 2,3,5,7, ale mniejsza od 1000

            //for (int i = 1000; i >0; i--)
            //{
            //if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
            //{
            //    Console.WriteLine(i);
            //    i = 0; // przeciążenie for lub break; 
            //}  

            //}



            #endregion

            #region Sprawdź czy podana jako parametr liczba jest parzysta. Istnieje mozliwosc wpisywania wartości do sprawdzenia wielokrotnie

            //bool endLoop = true;
            //while (endLoop) 
            //{
            //    Console.WriteLine(" Enter a number:");
            //    var userNum = Console.ReadLine();

            //    if (userNum=="q") 
            //    {
            //        endLoop = false;
            //        continue;
            //    }
            //    int num2;
            //    var result = int.TryParse(userNum, out num2);
            //    if (num2 % 2 == 0) 
            //    {
            //        Console.WriteLine($"{userNum} jest liczba parzysta");
            //    }
            //  else 
            //    {
            //        Console.WriteLine($"{userNum} Nie jest liczba parzystą");
            //    }
            //    Console.ReadLine();



            //}

            #endregion

            #region sprawdź czy podana jako parametr liczba jest liczbą pierwszą (podzielna tylko przez 1 i przez samą siebie). Mozesz wprowadzic tylko jedna liczbe do sprawdzenia

            //Console.WriteLine("Enetr a number:");
            //var userNum = Console.ReadLine();
            //int checkingNum;
            //var result = int.TryParse(userNum, out checkingNum);

            //if (result)
            //{
            //    if (checkingNum % 2 == 0 && checkingNum % 3 == 0 && checkingNum % 5 == 0)
            //    {
            //        Console.WriteLine($"{checkingNum} nie jest liczba pierwsza");
            //    }
            //    else
            //    {
            //        Console.WriteLine("To jest liczba pierwsza");
            //    }

            //}
            //else 
            //{
            //    Console.WriteLine("Błędna wartość");
            //}
            //Console.ReadLine();
            #endregion

            #region  sprawdź czy podana jako parametr liczba jest liczbą pierwszą (podzielna tylko przez 1 i przez samą siebie). Mozesz wprowadzic wiele liczb do sprawdzenia

            //bool czyPierwsza = true;
            //while (czyPierwsza) 
            //{
            //    Console.WriteLine("Enter a number:");
            //    var userNum = Console.ReadLine();
            //    if (userNum == "q") 
            //    {
            //        czyPierwsza = false;
            //        continue;
            //    }

            //    int checkingNum;
            //    var result = int.TryParse(userNum, out checkingNum);

            //    if (result) 
            //    {
            //    if(checkingNum%2==0 && checkingNum%3==0 && checkingNum % 5 == 0) 
            //        {
            //            Console.WriteLine($"{checkingNum} nie jest liczba pierwsza");

            //        }
            //    else 
            //        {
            //            Console.WriteLine($"{checkingNum} jest liczba pierwsza");
            //        }

            //    }
            //    else 
            //    {
            //        Console.WriteLine("Koniec");
            //        Console.ReadLine();
            //    }

            //}
            #endregion

            #region Sprawdz czy podany numer PESEL jest poprawny
            bool endLoop = true;
            
            while (endLoop) 
            {
                Console.WriteLine("Enter your PESEL number"); 
                var userImput = Console.ReadLine();
                if (userImput == "q")  // wielokrotna mozliwosc wpisywania numeru PESEL
                {
                    endLoop = false;
                    continue;
                }
                string [] num = new num[11];

                int checkinNum = 9a + 7b + 3c + 1d + 9e + 7f + 3g + 1h + 9i + 7j;
                var result = int.TryParse(userImput, out checkinNum);
               
            
            }

            #endregion
        }
    }
}
