using System;

namespace Day8;

class Program
{
    static void Main(string[] args)
    {
        #region Task1
        // Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək
        Console.Write("yazini daxil edin: ");
        string y = Console.ReadLine();
        string result = "";
        for (int i = 0; i < y.Length; i++)
        {

            if (y[i] != ' ')
            {
                result += y[i];
            }
        }
        Console.Write("bosluqsuz yazi: " + result);

        #endregion
        #region Task2

        //Verilmiş ədədlər siyahısındaki verilmiş n ədədinin yerləşdiyi indexi tapan proqram
        Console.Write("arrayin uzunlugunu daxil edin: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{i + 1} ci ededi daxil edin:");
            arr[i] = Convert.ToInt32(Console.ReadLine());

        }
        Console.Write("axtaracaginiz ededi daxil edin: ");
        int ax = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == ax)
            {
                Console.Write("axtardiginiz ededin indexi: " + i);
                break;
            }

        }
        #endregion
        #region Task3

        // Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram
        Console.Write("yazi siyahisinin uzunlugunu daxil edin: ");
        int s = Convert.ToInt32(Console.ReadLine());
        string[] arr1 = new string[s];
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write($"{i + 1} ci metni daxil edin: ");
            arr1[i] = Console.ReadLine();

        }
        Console.Write("axtaracaginiz herfi daxil edin: ");

        char h = Convert.ToChar(Console.ReadLine());

        int count = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            for (int j = 0; j < arr1[i].Length; j++)
            {
                if (arr1[i][j] == h)
                {
                    count++;
                }

            }

        }
        Console.WriteLine("axtardiniz herfin sayi: " + count);
        #endregion
        #region Task4

        // Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram(Misalçün verilmiş yazı "  " +
        // " salam necesen?   " - dirsə yeni düzələcək string "salam necəsən?   " olmalıdır.

        Console.Write("bir metn daxil edin: ");
        string Metn = Console.ReadLine();

        int say = 0;

        for (int i = 0; i < Metn.Length && Metn[i] == ' '; i++)
        {
            say++;
        }
        Console.WriteLine("evvelindeki bosluqlarin sayi: " + say);

        char[] charArrayi = new char[Metn.Length - say];
        for (int i = 0; i < charArrayi.Length; i++)
        {
            charArrayi[i] = Metn[say + i];
        }

        string Netice = new string(charArrayi);

        Console.WriteLine("evveldeki bosluqlar silinmis metn:" + Netice);

        #endregion

        #region Task5
        // Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram. Simvol +,-,*və ya / olmalıdır,
        //   əks halda simvolu yenidən daxil edilməsi istənilməlidir.(Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)

        Console.Write("1 ci ededi daxil edin: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("2 ci ededi daxil edin: ");
        int sec = Convert.ToInt32(Console.ReadLine());
        bool check;

        do
        {
            Console.Write("simvolu daxil edin: ");
            string sim = Console.ReadLine();
            check = true;
            switch (sim)
            {
                case "+": Console.WriteLine($"ededlerin cemi:{first + sec}"); break;
                case "-": Console.WriteLine($"ededlerin ferqi:{first - sec}"); break;
                case "*": Console.WriteLine($"ededlerin hasili:{first * sec}"); break;
                case "/": Console.WriteLine($"ededlerin nisbeti:{first / sec}"); break;

                default:
                    check = false;
                    Console.WriteLine("simvolu duzgun daxil edin zehmet olmasa !");
                    break;
            }

        } while (!check);
        #endregion
        Console.ReadLine();
    }
}

