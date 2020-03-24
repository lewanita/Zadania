using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Description of the excertice
            //Napisać metodę, która w zależności od podanego h narysuje na konsoli piramide.
            //Proszę sczytać wartość h z konsoli.
            //Np.
            //dla h = 2
            //*
            //**
            //Dla h = 3
            //  *
            //**
            //***
            //Dla h = 4
            //   *
            //  **
            //***
            //****
            //Dla wartości ujemnych piramida powinna być rysowana do góry nogami

            //string[] choinka = new string[4];
            //string star = "*";
            //choinka[0] = star;
            //string slowo1 = "**";
            //choinka[1] = slowo1;
            //string slowo2 = "***";
            //choinka[2] = slowo2;
            //string slowo3 = "****";
            //choinka[3] = slowo3;

            #endregion

            PyramidDraw();
            Console.ReadLine();
        }
        public static void PyramidDraw() 
        {
            Console.WriteLine(" Enter a hight of a pyramid");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine(" Choose a char for creating a pyramid");
            char znak = char.Parse(Console.ReadLine());
            Console.WriteLine("Normal(1) view or inverted (2)");
            string imput = Console.ReadLine();

            switch (imput.ToLower()) 
            {
                case "1"://normal
                    Console.WriteLine(" Wybrałes normalną");
                    {
                        for (int rzad = 0; rzad < h; rzad++)
                        {
                            for (int przestrzen = h - rzad; przestrzen > rzad; przestrzen--)
                            {
                                Console.WriteLine(" ");
                            }
                            for (int kolumna = 0; kolumna < (2 * rzad + 1); kolumna++)
                            {
                                Console.WriteLine(znak);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Zakonczono obliczanie");
                        Console.ReadLine();
                        break;

                    }
                case "2"://inverted
                    Console.WriteLine("Odrócona konstrukcja");
                    { 
                        for(int rzad=h;rzad >0;rzad--) 
                        {
                            for (int przestrzen = rzad; przestrzen < h; przestrzen++)
                            {
                                Console.WriteLine(" ");
                            }
                            for (int j = (2 * rzad - 1); j > 0; j--)
                            {
                                Console.WriteLine(znak);
                            }
                            Console.WriteLine();

                        }
                        Console.WriteLine("Zakonczono obliczanie");
                        Console.ReadLine();

                        break;
                    }
                default:
                    Console.WriteLine("Wprowadz wartosci raz jeszcze");
                    break;

            }
            Console.ReadLine();

           

            
            
        
        }
    }
}

