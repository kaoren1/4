using System;
using System.Drawing;

namespace _ПР2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход из программы");
            Console.WriteLine(" ");
            Console.WriteLine("Выберите программу: ");
            int k = Convert.ToInt32(Console.ReadLine());
            switch (k)
            {
                case 1:
                    Program.Igra();
                    break;
                case 2:
                    Program.Tabl();
                    break;
                case 3:
                    Program.Delit();
                    break;
                case 4:
                    break;
            }
        }
        static void Igra()
        {
            Console.WriteLine("Угадай число от 0 до 100");
            Random c = new Random();
            int r = c.Next(0, 100);
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != r)
            {
                string num = (a > r) ? "Меньше" : "Больше";
                Console.WriteLine(num);
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Верно!");
            Console.WriteLine(" ");
            Program.Main();
        }
        static void Tabl()
        {
            int[,] j = new int[10, 10];
            for (int column = 1; column < 10; column++)
            {
                for (int line = 1; line < 10; line++)
                {
                    j[column, line] = column * line;
                    Console.Write(j[column, line] + "\t");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
            Program.Main();
        }
        static void Delit()
        {
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int l = 1; l <= n; l++)
            {
                if (n % l == 0)
                    Console.Write(l + "  ");
            }
            Console.WriteLine("\n");
            Program.Main();
        }
    }
}