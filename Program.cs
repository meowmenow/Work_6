using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
//ИСП-23, Бирюков Георгий, 15.12.21
//Составить программу, которая считывает с клавиатуры числа и четные записывает в файл even.txt, нечетные записывает в файл odd.txt.
//Считывать числа до тех пор, пока не введено число 0. Далее рассчитать сумму нечетных чисел и произведение четных чисел

namespace Адовые_коды__13__Практическая_работа_тёртин_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader even1; //Ввод (чётные)
            StreamReader odd1; //Ввод (нечётные)
            StreamWriter even; //Вывод (чётные)
            StreamWriter odd; //Вывод (нечётные)
            int x,
                i,
                koll = 0,
                sum = 0,
                y = 1;
            Console.WriteLine("Вводите числа"); //Ввод текста
            odd = new StreamWriter(@"C:\users\user\source\repos\Адовые коды №13 (Практическая работа тёртин)\odd.txt"); //Путь в никуда
            even = new StreamWriter(@"C:\Users\User\source\repos\Адовые коды №13 (Практическая работа тёртин)\even.txt"); //Путь в куда
            do
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x != 0) //Ограничивает действия нуля
                {
                    if (x % 2 == 0) //Проверяет четность
                    {
                        even.WriteLine(x); //Вводит в файл
                    }
                    else
                    {
                        odd.WriteLine(x); //Ввод в файл (а вы ожидали другого?)
                    }
                    koll++; //kol++
                }

            } while (x != 0); //Условие конца цикла
            odd.Close(); //Закрыте файла
            even.Close(); //Закрытие файла (не опять, а снова)
            odd1 = new StreamReader(@"C:\users\user\source\repos\Адовые коды №13 (Практическая работа тёртин)\odd.txt"); //У самурая нет цели, только путь
            for (i = 1; i <= koll; i++) 
            {
                x = Convert.ToInt32(odd1.ReadLine());
                sum = sum + x; //Считает сумму
            }
            odd1.Close();
            even1 = new StreamReader(@"C:\users\user\source\reposадовые коды 13 для гейоргия\odd.txt");
            for (i = 1; i <= koll; i++) 
            {
                x = Convert.ToInt32(even1.ReadLine());
                if (x != 0) 
                    y = x * y; //Считает произведение
            }
            even1.Close(); //Закрыто
            Console.WriteLine("Сумма нечетных чисел " + sum);
            Console.WriteLine("Произведение четных чисел " + y);
            Console.ReadKey(); //Стоп-слово
        }
    }
}
