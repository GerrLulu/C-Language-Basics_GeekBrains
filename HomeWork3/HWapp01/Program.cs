using System;

namespace HWapp01
{
    struct Complex
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        public double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        public double im;

        public Complex Plus(Complex other)
        {
            Complex res;

            res.re = re + other.re;
            res.im = im + other.im;

            return res;

        }

        public Complex Minus (Complex other)
        {
            Complex res;

            res.re = re - other.re;
            res.im = im - other.im;

            return res;
        }

        public override string ToString()
        {
            return $"{re} + {im}i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задания выполнил студент: Демин Артем.");

            Console.WriteLine("Задание 1.\nа) Дописать структуру Complex, добавив метод вычитания комплексных чисел. " +
                "Продемонстрировать работу структуры.");
            Console.ReadLine();
            Console.Clear();

            Complex complex01;
            Console.Write("Введите число Re первого комплексного числа: ");
            complex01.re = int.Parse(Console.ReadLine());
            Console.Write("Введите число Im первого комплексного числа: ");
            complex01.im = int.Parse(Console.ReadLine());

            Complex complex02;
            Console.Write("Введите число Re второго комплексного числа: ");
            complex02.re = int.Parse(Console.ReadLine());
            Console.Write("Введите число Im второго комплексного числа: ");
            complex02.im = int.Parse(Console.ReadLine());

            Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} равна {complex01.Plus(complex02)}");
            Console.WriteLine($"Разница комплексных чисел {complex01} и {complex02} равна {complex01.Minus(complex02)}");

            Console.ReadKey();
        }
    }
}