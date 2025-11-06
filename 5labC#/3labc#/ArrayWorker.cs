using System;
using System.Diagnostics;

namespace _5lab
{
    /// <summary>
    /// Класс для работы с массивами целых чисел
    /// </summary>
    public class ArrayWorker
    {
        private int _length;
        private int[] _array;

        /// <summary>
        /// Количество элементов в массиве
        /// </summary>
        public int Length
        {
            get { return _length; }
            private set { _length = value; }
        }
        /// <summary>
        /// Массив целых чисел
        /// </summary>
        public int[] Array
        {
            get { return _array; }
            private set { _array = value; }
        }

        /// <summary>
        /// Конструктор по умолчанию, создающий массив из 10 элементов
        /// </summary>
        public ArrayWorker()
        {
            _length = 10;
            _array = GenerateRandomArray(_length);
        }

        /// <summary>
        /// Конструктор с параметром для создания массива заданного размера
        /// </summary>
        /// <param name="length">Количество элементов в массиве</param>
        public ArrayWorker(int length)
        {
            _length = length;
            _array = GenerateRandomArray(_length);
        }

        /// <summary>
        /// Генерирует массив случайных чисел
        /// </summary>
        /// <param name="n">Размер массива</param>
        /// <returns>Массив случайных чисел</returns>
        private int[] GenerateRandomArray(int n)
        {
            int[] arr = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            return arr;
        }

        /// <summary>
        /// Создает копию массива
        /// </summary>
        /// <returns>Новый массив с теми же значениями</returns>
        public int[] CopyArray()
        {
            int[] copyArr = new int[_length];
            for (int i = 0; i < _length; i++)
            {
                copyArr[i] = _array[i];
            }
            return copyArr;
        }

        /// <summary>
        /// Выводит массив на экран (только если длина <= 10)
        /// </summary>
        public void PrintArray()
        {
            if (_length > 10)
            {
                Console.WriteLine("Массивы не могут быть выведены на экран, так как длина массива больше 10.");
            }
            else
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    Console.Write(_array[i] + " ");
                }
                Console.Write("\n");
            }
        }

        /// <summary>
        /// Сортирует массив методом пузырька и возвращает время выполнения в миллисекундах
        /// </summary>
        /// <returns>Время выполнения сортировки в миллисекундах</returns>
        public double BubbleSort()
        {
            int[] arr = CopyArray();
            var stopwatch = Stopwatch.StartNew();

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            stopwatch.Stop();
            _array = arr;
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        /// <summary>
        /// Сортирует массив методом Шелла и возвращает время выполнения в миллисекундах
        /// </summary>
        /// <returns>Время выполнения сортировки в миллисекундах</returns>
        public double ShellSort()
        {
            int[] arr = CopyArray();
            var stopwatch = Stopwatch.StartNew();

            int n = arr.Length;
            int gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;
                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }
                    arr[j] = temp;
                }
                gap /= 2;
            }

            stopwatch.Stop();
            _array = arr;
            return stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}