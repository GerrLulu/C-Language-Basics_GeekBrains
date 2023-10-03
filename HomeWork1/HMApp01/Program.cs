using System;

namespace Lesson1
{
    class Program
    {
        static double Task2(double height, int weight)
        {
            return weight / (height * height);
        }

        static double Task3(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Task4()
        {
            Console.Write("Укажите значение переменной a: ");
            var aInput = int.Parse(Console.ReadLine());
            Console.Write("Укажите значение переменной b: ");
            var bInput = int.Parse(Console.ReadLine());

            int a = aInput;
            int b = bInput;

            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"\nа) a = {a}, b = {b}");

            a = aInput;
            b = bInput;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"\nб) a = {a}, b = {b}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задания выполнил студент: Демин Артем.");
            Console.ReadLine();
            Console.Clear();

            #region Task01
            Console.WriteLine("Задание 1.\nНаписать программу «Анкета». Последовательно задаются вопросы (имя, фамилия," +
                " возраст, рост, вес). В результате вся информация выводится в одну строчку:\nа) используя склеивание;\n" +
                "б) используя форматированный вывод;\nв) используя вывод со знаком $.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите Вашу фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите Ваш возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите Ваш рост в метрах: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Введите Ваш вес в кг: ");
            int weight = int.Parse(Console.ReadLine());

            Console.WriteLine("а) Ваше имя: " + name + "; Ваша фамилия: " + surname + "; Ваш возраст: " + age + "; Ваш " +
                "рост: " + height + "м; Ваш вес: " + weight + "кг.");
            Console.WriteLine("б) Ваше имя: {0}; Ваша фамилия: {1}; Ваш возраст: {2}; Ваш рост: {3}м; Ваш вес: {4}кг."
                , name, surname, age, height, weight);
            Console.WriteLine($"в) Ваше имя: {name}; Ваша фамилия: {surname}; Ваш возраст: {age}; Ваш рост: {height}м; " +
                $"Ваш вес: {weight}кг.");

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task02
            Console.WriteLine("\n\nЗадание 2.\nВвести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ)" +
                " по формуле I=m/(h*h), где m — масса тела в килограммах, h — рост в метрах.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Значения переменых взяты из прошлого задания");
            Console.WriteLine("\n\nВаш индекс массы тела (ИМТ) составляет: {0:N2}", Task2(height, weight));

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task03
            Console.WriteLine("Задание 3.\nа) Написать программу, которая подсчитывает расстояние между точками с " +
                "координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести " +
                "результат, используя спецификатор формата .2f (с двумя знаками после запятой);\nб) * Выполнить " +
                "предыдущее задание, оформив вычисления расстояния между точками в виде метода.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите координаты x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Введите координаты y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Введите координаты x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Введите координаты y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Расстояние между точками равно: {0:F2}", Task3(x1, y1, x2, y2));

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task04
            Console.WriteLine("Задание 4.\nНаписать программу обмена значениями двух переменных типа int без " +
                "использования вспомогательных методов.\nа) с использованием третьей переменной;\nб) *без использования" +
                " третьей переменной.");
            Console.ReadLine();
            Console.Clear();

            Task4();

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task05
            Console.WriteLine("Задание 5.\nа) Написать программу, которая выводит на экран ваше имя, фамилию и город " +
                "проживания.\nб) Сделать задание, только вывод организовать в центре экрана.\nв) *Сделать задание б с " +
                "использованием собственных методов (например, Print(string ms, int x, int y).");
            Console.ReadLine();
            Console.Clear();

            OutputHelpers.PrintInCenter("Меня зовут Артем. Живу я в городе Хабаровск.");
            OutputHelpers.Pause();

            Console.ReadLine();
            #endregion
        }
    }

    public class OutputHelpers
    {
        public static void PrintInCenter(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.WindowHeight / 2 - 1);
            Console.WriteLine(text);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}
