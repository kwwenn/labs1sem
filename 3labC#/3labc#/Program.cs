using System; //4 var
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Policy;


namespace _2lab
{
    internal class Program
    {
        static int intInput()
        {
            int number;
            while((!int.TryParse((Console.ReadLine()), out number)))
            { Console.WriteLine("Ошибка. Введите число"); }
            return number;
            
        }
        static double doubleInput()
        {
            double number;
            while ((!double.TryParse((Console.ReadLine()), out number)))
            { Console.WriteLine("Ошибка. Введите число"); }
            return number;

        }
        static int lenInput()
        {
            int number;
            while ((!int.TryParse((Console.ReadLine()), out number)) || number < 0)
            { Console.WriteLine("Ошибка. Введите положительное число"); }
            return number;

        }
        static int[] newArray(int n)
        {
            int[] arr = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            return arr;
        }
        static int[] copyArray(int[] arr)
        {
            int[] copyArr = (int[])arr.Clone();
            return copyArr;
        } 
        static void printArray(int[] arr)
        {
            if (arr.Length > 10)
            { 
                Console.WriteLine("“Массивы не могут быть выведены на экран, так как длина массива больше 10”."); 
            }
            else
            {
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.Write("\n");
            }
        } 
        static void bubbleSort(int[] arr)
        {
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
        }
        static void shellSort(int[] arr)
        {
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
        }
        static double func(int a, int b)
        {
            const double pi = Math.PI;
            return (Math.Pow(Math.Cos(pi), 7) + Math.Sqrt(Math.Log(Math.Pow(b, 4)))) / Math.Pow(Math.Sin((pi / 2) + a), 2);
        }
        static void guess(double f)
        {
            double hypot = 0;
            int counter = 0;

            while (hypot != Math.Round(f, 2) && counter < 3)
            {
                Console.WriteLine("Попыток осталось: " + (3 - counter));

                Console.Write("Введите ответ: ");
                hypot = doubleInput();

                if (counter >= 3)
                {
                    Console.WriteLine($"Вы проиграли. Правильный ответ: {Math.Round(f, 2)}");
                }

                if (hypot == Math.Round(f, 2))
                {
                    Console.WriteLine("Ответ верный. Вы победили!");
                }
                else
                {
                    ++counter;
                    Console.WriteLine("Ответ неверный, попробуйте еще раз");
                }
            }
        }
        static void game()
        {

            Console.Write("Введите а: ");
            int a = intInput();

            Console.Write("Введите b: ");
            int b = intInput();

            double function = func(a, b);

            guess(function);
        }
        static void author()
        {
            Console.WriteLine("Гаврилов Дмитрий Сергеевич 6101-090301D");
        }
        static void sort()
        {
            int n = lenInput();
            int[] arr = newArray(n);
            int[] copyArr = copyArray(arr);
            int[] origArr = copyArray(arr);
            var time1 = Stopwatch.StartNew();
            bubbleSort(arr);
            time1.Stop();
            
            var time2 = Stopwatch.StartNew();
            shellSort(copyArr);
            time2.Stop();
            
            Console.WriteLine($"Время выполнения сортировки пузырьком: {time1.Elapsed.TotalSeconds} с");
            Console.WriteLine($"Время выполнения сортировки Шелла: {time2.Elapsed.TotalSeconds} с");
            if (n > 10)
            {
                printArray(arr);
            }
            else
            {
                Console.WriteLine("Исходный массив:");
                printArray(origArr);
                Console.WriteLine("Отсортированный массив:");
                printArray(arr);
            }
        }
        static bool exit()
        {
            Console.WriteLine("Вы уверены, что хотите выйти? (д/н)");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "д":
                    return false;
                case "н":
                    return true;
                default:
                    Console.WriteLine("Некорректный ввод, попробуйте снова.");
                    return true;
            }
        }

        static void Main(string[] args)
        {
            bool start = true;
            while (start)
            {
                Console.WriteLine("Меню:\n 1. Отгадай ответ\n 2. Об авторе\n 3. Сортировка массивов\n 4. Выход");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        game();
                        break; 

                    case "2":
                        author(); 
                        break;

                    case "3":
                        Console.WriteLine("Введите длину массива:");
                        sort(); break;

                    case "4":
                        bool confirm = true;
                        while (confirm)
                        {
                            bool ex = exit();
                            if (ex == false)
                            {
                                start = false;
                                confirm = false;

                            }
                            else
                            {
                                confirm = false;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Некорректный ввод, попробуйте снова."); break;
                }
            }
        }
    }
}
