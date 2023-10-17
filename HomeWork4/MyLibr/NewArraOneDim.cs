using System;
using System.IO;

namespace MyLibr
{
    public static class ArrayOneDim
    {
        /// <summary>
        /// Метод создающий массив.
        /// </summary>
        /// <param name="n">Кол-во элементов массива.</param>
        /// <param name="min">Минимальное значение элемента массива.</param>
        /// <param name="max">Максимальное значение элемента массива.</param>
        /// <returns></returns>
        public static int[] NewArray(int n, int min, int max)
        {
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                array[i] = rnd.Next(min, max);
            return array;
        }

        /// <summary>
        /// Метод, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
        /// </summary>
        /// <param name="arr">Массив для проверки условий.</param>
        /// <returns></returns>
        public static int DivideByThree(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % 3 == 0 || arr[i + 1] % 3 == 0)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Метод считывающий массива из текстового файла, потом возвращающий массив целых чисел.
        /// </summary>
        /// <param name="fileName">Название текстового файла.</param>
        /// <returns></returns>
        public static int[] NewArray(string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamReader sr = new StreamReader(fileName);
                int[] a = new int[100];
                int count = 0;
                while (!sr.EndOfStream)
                {
                    int number = int.Parse(sr.ReadLine());
                    a[count] = number;
                    count++;
                }
                int[] arr = new int[count];
                Array.Copy(a, 0, arr, 0, count);
                sr.Close();
                return arr;
            }
            else
                throw new FileNotFoundException();
        }
    }

    public class NewArraOneDim
    {
        private int[] _array;

        /// <summary>
        /// Свойство для получения суммы элементов массива.
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < _array.Length; i++)
                    sum = sum + _array[i];
                return sum;
            }
        }
        /// <summary>
        /// Cвойство, возвращающее количество максимальных элементов.
        /// </summary>
        public int MaxCount
        {
            get
            {
                int count = 0;
                int max = _array[0];
                for (int i = 0; i < _array.Length; i++)
                {
                    if (_array[i] > max)
                        max = _array[i];
                    if (_array[i] == max)
                        count++;
                }
                return count;
            }
        }


        /// <summary>
        /// Конструктор по созданию массива с определенным шагом.
        /// </summary>
        /// <param name="arrSize">Размер массива.</param>
        /// <param name="firstElement">Начальное значение.</param>
        /// <param name="step">Шаг</param>
        public NewArraOneDim(int arrSize, int firstElement, int step)
        {
            _array = new int[arrSize];
            _array[0] = firstElement;

            for (int i = 1; i < arrSize; i++)
                _array[i] = _array[i - 1] + step;
        }


        /// <summary>
        /// Метод, возвращающий новый массив с измененными знаками у всех элементов массива.
        /// </summary>
        public void Inverse()
        {
            string s = "";
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = _array[i] * -1;
                s = s + $"\t{_array[i]}";
            }
            Console.WriteLine($"Инверсия элементов массива: {s}");
        }

        /// <summary>
        /// Метод, умножающий каждый элемент массива на определённое число.
        /// </summary>
        public void Multi(int n)
        {
            string s = "";
            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = _array[i] * n;
                s = s + $"\t{_array[i]}";
            }
            Console.WriteLine($"Домноженные элементы массива: {s}");
        }

        /// <summary>
        /// Метод для вывода массива.
        /// </summary>
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < _array.Length; i++)
                s = s + $"\t{_array[i]}";
            return s;
        }

    }


    public class ArrayTwoDim
    {
        private int[,] _array;

        /// <summary>
        /// Свойство, возвращающее минимальный элемент массива
        /// </summary>
        public int Min
        {
            get
            {
                int min = _array[0, 0];
                for (int i = 0; i < _array.GetLength(0); i++)
                    for (int j = 0; j < _array.GetLength(1); j++)
                        if (_array[i, j] < min)
                            min = _array[i, j];
                return min;
            }
        }
        /// <summary>
        /// Свойство, возвращающее максимальный элемент массива
        /// </summary>
        public int Max
        {
            get
            {
                int max = _array[0, 0];
                for (int i = 0; i < _array.GetLength(0); i++)
                    for (int j = 0; j < _array.GetLength(1); j++)
                        if (_array[i, j] > max)
                            max = _array[i, j];
                return max;
            }
        }


        /// <summary>
        /// Конструктор создающий двухмерные массивы
        /// </summary>
        /// <param name="n">Кол-во строк</param>
        /// <param name="m">Кол-во столбцов</param>
        /// 
        public ArrayTwoDim(int n, int m)
        {
            _array = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    _array[i, j] = rnd.Next();
        }

        /// <summary>Конструктор, считывающий двумерный массив из файла</summary>
        /// <param name="filename">Имя файла</param>
        public ArrayTwoDim(string filename)
        {
            filename = "..\\..\\" + filename;
            string[] fileArray = new string[0];
            try
            {
                fileArray = File.ReadAllLines(filename);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File doesnt exist in : " + filename);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Exception catched: " + ex.Message);
            }

            _array = new int[fileArray.Length, fileArray.Length];
            for (int i = 0; i < fileArray.Length; i++)
            {
                string[] tempArray = fileArray[i].Split(' ');
                for (int j = 0; j < fileArray.Length; j++)
                    _array[i, j] = int.Parse(tempArray[j]);
            }
        }


        /// <summary>
        /// Методы, который возвращает сумму всех элементов массива
        /// </summary>
        /// <param name="sum">Сумма элементов массива</param>
        public void Sum(out long sum)
        {
            sum = 0;
            for (int i = 0; i < _array.GetLength(0); i++)
                for (int j = 0; j < _array.GetLength(1); j++)
                    sum = sum + _array[i, j];
        }

        /// <summary>
        /// метод, который сумму всех элементов массива больше заданного
        /// </summary>
        /// <param name="sum">Сумма элементов массива</param>
        /// <param name="x">Заданая строка</param>
        /// <param name="y">Заданый столбец</param>
        public void SumMoreGiven(out long sum, int x, int y)
        {
            sum = 0;
            int min = _array[x, y];
            for (int i = 0; i < _array.GetLength(0); i++)
                for (int j = 0; j < _array.GetLength(1); j++)
                    if (_array[i, j] > min)
                        sum = sum + _array[i, j];
        }

        /// <summary>
        /// Метод, возвращающий номер максимального элемента массива
        /// </summary>
        /// <param name="index">Номер массива</param>
        public void NumMaxElementArray(out string index)
        {
            index = "";
            for (int i = 0; i < _array.GetLength(0); i++)
                for (int j = 0; j < _array.GetLength(1); j++)
                    if (_array[i, j] == Max)
                        index = i + ", " + j;
        }

        /// <summary>
        /// Метод для вывода массива.
        /// </summary>
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < _array.GetLength(0); i++)
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                    s = s + $"{_array[i, j]}  ";

                s = s + "\n";
            }
            return s;
        }

        /// <summary>Метод, записывающий двумерный массив в файл</summary>
        /// <param name="filename">Название файла</param>
        public void SaveIntoFile(string filename)
        {
            filename = "..\\..\\" + filename;
            try
            {
                StreamWriter wr = new StreamWriter(filename);
                for (int i = 0; i < _array.GetLength(0); i++)
                {
                    for (int j = 0; j < _array.GetLength(1); j++)
                        wr.Write(_array[i, j] + " ");
                    wr.Write(Environment.NewLine);
                }
                wr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File doesnt exist in : " + filename);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Exception catched: " + ex.Message);
            }
        }
    }
}