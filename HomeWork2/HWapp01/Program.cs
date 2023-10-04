using System;

namespace Lesson2
{
    class Program
    {
        static double ReturnMin (double a, double b, double c)
        {
            return (a < b && a < c) ? a : (b < a && b < c) ? b : c;
        }

        static int CountingNumbers (string num)
        {
            int count = 0;
            foreach (char element in num)
            {
                if (element == ',' || element == '.' || element == '-')
                    continue;
                count++;
            }
            /*if (Char.IsDigit(element) == true)
             * count++
              - по сути аналогичное решение данной задачи; оператор Char.IsDigit(element) выбирает только числа (нашел
            на просторах интернета)*/
            return count;
        }

        static int CheckPswrdLgn(string login, string password, int attempt)
        {
            string msg = "";

            Console.Write("Введите Ваш логин: ");
            string inputLgn = Console.ReadLine();

            Console.Write("Введите Ваш пароль: ");
            string inputPsswrd = Console.ReadLine();

            if (inputLgn == login && inputPsswrd == password)
            {
                Console.WriteLine("Логин и пароль верны.");
                return attempt;
            }
            else
            {
                attempt++;
                switch (attempt)
                {
                    case 1:
                        msg = "У Вас осталось 2 попытки.";
                        break;
                    case 2:
                        msg = "У Вас осталась 1 попытка.";
                        break;
                    case 3:
                        msg = "Вы не ввели правильный логин и пароль. Консоль будет закрыта.";
                        break;
                }
                Console.WriteLine(msg);
            }
            return attempt;
        }

        static void ExitProgram()
        {
            Console.ReadLine();
            Environment.Exit(0);
        }

        static void GetOutput(double height, double weight)
        {
            string msg1 = "Необходима срочная консультация специалиста.";
            string msg2 = "Необходима консультация специалиста.";
            string msg3 = "Вам необходимо набрать";
            string msg4 = "Вам необходимо сбросить";

            double maxWeight = 24.99 * height * height;
            double minWeight = 18.5 * height * height;

            switch(GetBMI(height, weight))
            {
                case 1:
                    Console.WriteLine($"У Вас выраженный дефицит массы тела. {msg1}\n{msg3} от {minWeight - weight:N2} " +
                        $"до {maxWeight - weight:N2} кг.");
                    break;
                case 2:
                    Console.WriteLine($"У Вас недостаточная (дефицит) масса тела. {msg2}\n{msg3} от " +
                        $"{minWeight - weight:N2} до {maxWeight - weight:N2} кг.");
                    break;
                case 3:
                    Console.WriteLine("У Вас все нормально.");
                    break;
                case 4:
                    Console.WriteLine($"У Вас избыточная масса тела (предожирение) и повышенный риск сердечно " +
                        $"сосудистого заболевания.\n{msg2}\n{msg4} от {weight - maxWeight:N2} до {weight - minWeight:N2} кг.");
                    break;
                case 5:
                    Console.WriteLine($"У Вас ожирение первой степени и высокий риск сердечно сосудистого заболевания." +
                        $"\n{msg2}\n{msg4} от {weight - maxWeight:N2} до {weight - minWeight:N2} кг.");
                    break;
                case 6:
                    Console.WriteLine($"У Вас ожирение второй степени и очень высокий риск сердечно сосудистого " +
                        $"заболевания.\n{msg2}\n{msg4} от {weight - maxWeight:N2} до {weight - minWeight:N2} кг.");
                    break;
                case 7:
                    Console.WriteLine($"У Вас ожирение третьей степени (морбидное) и чрезвычайно высокий риск сердечно " +
                        $"сосудистого заболевания.\n{msg1}\n{msg4} от {weight - maxWeight:N2} до {weight - minWeight:N2} кг.");
                    break;
            }
        }

        static int GetBMI(double height, double weight)
        {
            int forCase;
            double bmi = weight / (height * height);

            if (bmi < 16)
                forCase = 1;
            else if (16 <= bmi && bmi < 18.5)
                forCase = 2;
            else if (18.5 <= bmi && bmi < 25)
                forCase = 3;
            else if (25 <= bmi && bmi < 30)
                forCase = 4;
            else if (30 <= bmi && bmi < 35)
                forCase = 5;
            else if (35 <= bmi && bmi < 40)
                forCase = 6;
            else
                forCase = 7;

            return forCase;
        }

        static bool CheckGoodNumber(int i)
        {
            int k = i;
            int sumNumber = 0;
            while (k > 0)
            {
                sumNumber = sumNumber + (k % 10);
                k = k / 10;
            }
            return i % sumNumber == 0;
        }

        static void PrintNumber(int x, int y)
        {
            if (x <= y)
            {
                Console.WriteLine(x);
                x++;
                PrintNumber(x, y);
            }
        }

        static int SumNumber(int x, int y)
        {
            if(x <= y)
            {
                var s = SumNumber(x + 1, y);
                return x + s;
            }
            return 0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Задания выполнил студент: Демин Артем.");
            Console.ReadLine();
            Console.Clear();

            #region Task01
            Console.WriteLine("Задание 1.\nНаписать метод, возвращающий минимальное из трёх чисел.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите число a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите число c: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Минимальное число из трёх: " + ReturnMin(a, b, c));

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task02
            Console.WriteLine("Задание 2.\nНаписать метод подсчета количества цифр числа.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите любое число: ");
            string number = Console.ReadLine();

            Console.WriteLine("Количество цифр в числе: " + CountingNumbers(number));

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task03
            Console.WriteLine("Задание 3.\nС клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех " +
                "нечетных положительных чисел.");
            Console.ReadLine();
            Console.Clear();

            int n = -1;
            int sum = 0;

            while(n != 0)
            {
                Console.Write("Введите любое целое число (число 0 останавливает программу): ");
                n = int.Parse(Console.ReadLine());
                if (n > 0 && (n % 2 != 0))
                    sum = sum + n;
                Console.Clear();
            }
            Console.WriteLine("Сумма нечетных положитедльных чисел равна: " + sum);

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task04
            Console.WriteLine("Задание 4.\nРеализовать метод проверки логина и пароля. На вход метода подается логин и " +
                "пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: " +
                "GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и" +
                " пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод " +
                "пароля тремя попытками.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("У Вас 3 попытки на введения логина и пароля.");

            string login = "root";
            string password = "GeekBrains";
            int attempt = 0;

            do
            {
                CheckPswrdLgn(login, password, attempt);
            }
            while (attempt < 3);
            
            if (attempt == 3)
            {
                ExitProgram();
            }

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task05
            Console.WriteLine("Задание 5.\nа) Написать программу, которая запрашивает массу и рост человека, вычисляет " +
                "его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.\nб) * Рассчитать," +
                " на сколько кг похудеть или сколько кг набрать для нормализации веса.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите Ваш рост в метрах: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Введите Ваш вес в кг: ");
            double weight = double.Parse(Console.ReadLine());

            GetOutput(height, weight);

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task06
            Console.WriteLine("Задание 6.\n*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до " +
                "1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт " +
                "времени выполнения программы, используя структуру DateTime.");
            Console.ReadLine();
            Console.Clear();

            int count = 0;
            DateTime start = DateTime.Now;
            for (int i = 1; i <= 1000000000; i++)
            {
                if (CheckGoodNumber(i))
                    count++;
            }
            Console.WriteLine($"Количество 'хороших' чисел равно: {count}. Задача решена за время: {DateTime.Now - start}");

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task07
            Console.WriteLine("Задание 7.\na) Разработать рекурсивный метод, который выводит на экран числа от a до " +
                "b (a<b).\nб) * Разработать рекурсивный метод, который считает сумму чисел от a до b.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите меньшее число (x): ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите большее число (y): ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Вывод чисел от x до y: \n");
            PrintNumber(x, y);

            int sumNumbers = SumNumber(x, y) + y;
            Console.ReadLine();
            Console.WriteLine($"Сумма чисел: {sumNumbers}");

            Console.ReadLine();
            Console.Clear();
            #endregion
        }
    }
}