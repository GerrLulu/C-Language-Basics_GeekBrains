using MyLibr;
using System;
using System.IO;

namespace HWapp01
{
    struct Account
    {
        /// <summary>
        /// Метод проверки логина и пароля из .txt файла.
        /// </summary>
        /// <param name="fileLogPsswrd">Название текстового файла.</param>
        /// <returns></returns>
        public static bool Check(string fileLogPsswrd)
        {
            if (File.Exists(fileLogPsswrd))
            {
                StreamReader sr = new StreamReader(fileLogPsswrd);
                string login = sr.ReadLine();
                string password = sr.ReadLine();
                if (login == "root" && password == "GeekBrains")
                    return true;
                else
                    return false;
            }
            else
                throw new FileNotFoundException();
        }
    }

    class Program
    {
        /// <summary>
        /// Метод считывает строку и проверяет на корректный целочисленный ввод.
        /// </summary>
        /// <returns></returns>
        static int GetNumeral()
        {
            {
                while (true)
                    if (!int.TryParse(Console.ReadLine(), out int x))
                        Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
                    else return x;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задания выполнил студент: Демин Артем.");
            Console.ReadLine();
            Console.Clear();

            #region Task01 and Task02
            Console.WriteLine(@"Задание 1.
                Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 
                включительно.Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов 
                массива, в которых только одно число делится на 3.В данной задаче под парой подразумевается два подряд идущих элемента 
                массива.");
            Console.ReadLine();

            Console.WriteLine(@"Задание 2.
                Реализуйте задачу 1 в виде статического класса StaticClass;
                а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
                б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
                в)*Добавьте обработку ситуации отсутствия файла на диске.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите размерность массива: ");
            int arraySize = GetNumeral();

            Console.Write("Введите число от которого будут задваться элементы массива: ");
            int fromStart = GetNumeral();

            Console.Write("Введите число до которого будут задваться элементы массива: ");
            int toEnd = GetNumeral();

            int[] array01;
            array01 = ArrayOneDim.NewArray(arraySize, fromStart, toEnd);
            Console.WriteLine($"Количество пар элементов созданного массива, в которых только одно число делится на 3: {ArrayOneDim.DivideByThree(array01)}");

            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите название текстового файла с которого будет создан массив: ");
            string fileName = Console.ReadLine();
            int[] array02;
            array02 = ArrayOneDim.NewArray(AppDomain.CurrentDomain.BaseDirectory + fileName);
            Console.WriteLine($"Количество пар элементов массива, взятого из текста, в которых только одно число делится на 3: {ArrayOneDim.DivideByThree(array02)}");

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task03
            Console.WriteLine(@"Задание 3.
                а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив
                определенного размера и заполняющий массив числами от начального значения с заданным шагом. Создать
                свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив
                с измененными знаками у всех элементов массива (старый массив, остается без изменений), метод Multi,
                умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество
                максимальных элементов.
                б) * *Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки;
                в) ***Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary< int,int>)");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите размерность массива: ");
            int arrSize = GetNumeral();

            Console.Write("Введите первое число массива: ");
            int firstElement = GetNumeral();

            Console.Write("Введите шаг массива: ");
            int step = GetNumeral();
            Console.ReadKey();
            Console.Clear();

            NewArraOneDim array03 = new NewArraOneDim(arrSize, firstElement, step);

            Console.WriteLine($"Новый массив:\n{array03.ToString()}");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Сумма всех элементов массива: {array03.Sum}");
            Console.ReadKey();
            Console.Clear();

            array03.Inverse();
            Console.ReadKey();
            Console.Clear();

            Console.Write("Введите число на которое будете умножать эелементы массива: ");
            int n = GetNumeral();
            array03.Multi(n);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Кол-во максимальных элементов: {array03.MaxCount}");

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task04
            Console.WriteLine(@"Задание 4.
                Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
                Создайте структуру Account, содержащую Login и Password.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("У Вас 3 попытки на введения логина и пароля.");

            int attempt = 0;
            string msg = "";

            do
            {
                Console.Write("Введите название текстового файла в котором хранятся логин и пароль: ");
                string fileLogPsswrd = Console.ReadLine();

                if (Account.Check("..\\..\\" + fileLogPsswrd) == true)
                {
                    Console.WriteLine("Логин и пароль верны.");
                    break;
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
            } while (attempt < 3);

            if (attempt == 3)
            {
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Task05
            Console.WriteLine(@"Задание 5.
                а) Реализовать библиотеку с классом для работы с двумерным массивом. Реализовать конструктор, заполняющий
                массив случайными числами. Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов
                массива больше заданного, свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный
                элемент массива, метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор
                ref или out).
                * б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
                * *в) Обработать возможные исключительные ситуации при работе с файлами.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите кол-во строк массива: ");
            int a = GetNumeral();

            Console.Write("Введите кол-во столбцов массива: ");
            int b = GetNumeral();

            ArrayTwoDim array04 = new ArrayTwoDim(a, b);

            Console.WriteLine($"Созданный массив:\n{array04.ToString()}");
            Console.ReadLine();
            Console.Clear();

            long sum = 0;
            array04.Sum(out sum);
            Console.WriteLine($"Сумма элементов массива: {sum}");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите строку выбранного элемента массива: ");
            int line = GetNumeral();

            Console.Write("Введите столбец выбранного элемента массива: ");
            int column = GetNumeral();

            long sum2 = 0;
            array04.SumMoreGiven(out sum2, line, column);
            Console.WriteLine($"Сумма элементов массива, которые больше заданного элемента массива: {sum2}");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Минимальный элемент массива: {array04.Min}");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Максимальный элемент массива: {array04.Max}");
            Console.ReadLine();
            Console.Clear();

            string index = "";
            array04.NumMaxElementArray(out index);
            Console.WriteLine($"Индекс максимального эелемента массива: {index}");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите название текстового файла с которого будет создан двухмерный массив: ");
            string loadFileName = Console.ReadLine();
            ArrayTwoDim array05 = new ArrayTwoDim(loadFileName);

            Console.WriteLine($"Созданный массив:\n{array05.ToString()}");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Введите название текстового файла в который будет сохранен массив: ");
            string saveFileName = Console.ReadLine();
            array05.SaveIntoFile(saveFileName);

            Console.ReadLine();
            Console.Clear();
            #endregion
        }
    }
}