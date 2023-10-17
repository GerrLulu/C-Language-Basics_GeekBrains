using System;

namespace HWapp03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задания выполнил студент: Демин Артем.");

            Console.WriteLine("Задание 2.\nа) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой" +
                " строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на " +
                "экран, используя tryParse.");
            Console.ReadLine();
            Console.Clear();

            int n = -1;
            int sum = 0;
            bool flag = true;
            while (n != 0 || flag == false)
            {
                Console.Write("Введите любое целое число (число 0 останавливает программу): ");
                flag = int.TryParse(Console.ReadLine(), out n);
                if (n > 0 && (n % 2 != 0))
                {
                    sum = sum + n;
                    Console.WriteLine($"Вы ввели число: {n}.");
                }
                else if (flag == false)
                {
                    Console.WriteLine("Вы ввели некорректное число.");
                }
            }
            Console.WriteLine($"Сумма нечетных положитедльных чисел равна: {sum}.");

            Console.ReadLine();
        }
    }
}