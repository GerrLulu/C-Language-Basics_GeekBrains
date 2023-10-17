using System;

namespace HWapp02
{
    class Complex
    {
        /// <summary>
        /// Действительная часть комплексного числа
        /// </summary>
        double re;

        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        double im;

        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public Complex Plus(Complex other)
        {
            return new Complex(re + other.re, im + other.im);
        }

        public Complex Minus(Complex other)
        {
            return new Complex(re - other.re, im - other.im);
        }

        public Complex Multiply(Complex other)
        {
            return new Complex(re * other.re - im * other.im, re * other.im + im * other.re);
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

            Console.WriteLine("Задание 1.\nб) Дописать класс Complex, добавив методы вычитания и произведения чисел. " +
                "Проверить работу класса.\nв) Добавить диалог с использованием switch демонстрирующий работу класса.");
            Console.ReadLine();
            Console.Clear();

            Complex complex01 = EnteringValues(1);
            Complex complex02 = EnteringValues(2);

            Console.Clear();

            Solution(complex01 , complex02);
        }

        static Complex EnteringValues(int num)
        {
            Console.Write($"Введите число Re {num}-го комплексного числа: ");
            int re = int.Parse(Console.ReadLine());
            Console.Write($"Введите число Im {num}-го комплексного числа: ");
            int im = int.Parse(Console.ReadLine());

            return new Complex(re, im);
        }

        static void Solution(Complex complex01, Complex complex02)
        {
            bool flag = true;

            while (flag == true)
            {
                Console.Write("Введите необходимый знак для сложения, вычитания или умножения комплексных чисел. Для " +
                    "выхода из программы введите 0.");
                char symbol = Convert.ToChar(Console.ReadLine());

                switch (symbol)
                {
                    case '+':
                        Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} равна " +
                            $"{complex01.Plus(complex02)}");
                        flag = false;
                        break;
                    case '-':
                        Console.WriteLine($"Разность комплексных чисел {complex01} и {complex02} равна " +
                            $"{complex01.Minus(complex02)}");
                        flag = false;
                        break;
                    case '*':
                        Console.WriteLine($"Произведение комплексных чисел {complex01} и {complex02} равно " +
                            $"{complex01.Multiply(complex02)}");
                        flag = false;
                        break;
                    case '0':
                        Environment.Exit(0);
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Знак не распознан.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}