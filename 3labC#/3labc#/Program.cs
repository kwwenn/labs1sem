using System; //4 var
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Policy;


namespace _3lab
{
    internal class Program
    {
        static int IntInput()
        {
            int number;
            while((!int.TryParse((Console.ReadLine()), out number)))
            { Console.WriteLine("Ошибка. Введите число"); }
            return number;
            
        }
        static double DoubleInput()
        {
            double number;
            while ((!double.TryParse((Console.ReadLine()), out number)))
            { Console.WriteLine("Ошибка. Введите число"); }
            return number;

        }
        static int LenInput()
        {
            int number;
            while ((!int.TryParse((Console.ReadLine()), out number)) || number < 0)
            { Console.WriteLine("Ошибка. Введите положительное число"); }
            return number;

        }
        static int[] NewArray(int n)
        {
            int[] arr = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            return arr;
        }
        static int[] CopyArray(int[] arr)
        {
            int N = arr.Length;
            int[] copyArr = new int[N];
            for (int i = 0; i < N; i++)
            {
                copyArr[i] = arr[i];
            }
            return copyArr;
        } 
        static void PrintArray(int[] arr)
        {
            if (arr.Length > 10)
            { 
                Console.WriteLine("Массивы не могут быть выведены на экран, так как длина массива больше 10."); 
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
        static void BubbleSort(int[] arr)
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
        static void ShellSort(int[] arr)
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
        static double Func(int a, int b)
        {
            const double pi = Math.PI;
            return (Math.Pow(Math.Cos(pi), 7) + Math.Sqrt(Math.Log(Math.Pow(b, 4)))) / Math.Pow(Math.Sin((pi / 2) + a), 2);
        }
        static void Guess(double f)
        {
            double hypot = 0;
            int counter = 0;

            while (hypot != Math.Round(f, 2) && counter < 3)
            {
                Console.WriteLine("Попыток осталось: " + (3 - counter));

                Console.Write("Введите ответ: ");
                hypot = DoubleInput();

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
        static void Game()
        {

            Console.Write("Введите а: ");
            int a = IntInput();

            Console.Write("Введите b: ");
            int b = IntInput();

            double function = Func(a, b);

            Guess(function);
        }
        static void Author()
        {
            Console.WriteLine("Гаврилов Дмитрий Сергеевич 6101-090301D");
        }
        static void Sort()
        {
            Console.WriteLine("Введите длину массива:");
            int n = LenInput();
            int[] arr = NewArray(n);
            int[] copyArr = CopyArray(arr);
            int[] origArr = CopyArray(arr);
            var time1 = Stopwatch.StartNew();
            BubbleSort(arr);
            time1.Stop();
            
            var time2 = Stopwatch.StartNew();
            ShellSort(copyArr);
            time2.Stop();
            
            Console.WriteLine($"Время выполнения сортировки пузырьком: {time1.Elapsed.TotalSeconds} с");
            Console.WriteLine($"Время выполнения сортировки Шелла: {time2.Elapsed.TotalSeconds} с");
            if (n > 10)
            {
                PrintArray(arr);
            }
            else
            {
                Console.WriteLine("Исходный массив:");
                PrintArray(origArr);
                Console.WriteLine("Отсортированный массив:");
                PrintArray(arr);
            }
        }
        static bool Exit()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Вы уверены, что хотите выйти? (д/н)");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "д":
                        confirm = false;
                        return false;


                    case "н":
                        confirm = false;
                        return true;

                        break;
                    default:
                        Console.WriteLine("Некорректный ввод, попробуйте снова.");
                        break;
                }
            }
            return true;
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
                        Game();
                        break; 

                    case "2":
                        Author();
                        break;

                    case "3":
                        Sort(); 
                        break;

                    case "4":
                        start = Exit();
                        break;

                    default:
                        Console.WriteLine("Некорректный ввод, попробуйте снова."); break;
                }
            }
        }
    }
}
