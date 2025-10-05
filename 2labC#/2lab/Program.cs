using System;

namespace _2lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool start = true;
            while (start)
            {
                Console.WriteLine("Меню:\n 1. Отгадай ответ\n 2. Об авторе\n 3. Выход");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        const double pi = Math.PI;
                        int a;
                        int b;
                        double hypot = 0;
                        int counter = 0;
                        
                        Console.Write("Введите а: ");
                        while ((!int.TryParse(Console.ReadLine(), out a)))
                        { Console.WriteLine("Ошибка. Введите число"); }
                        
                        Console.Write("Введите b: ");
                        while ((!int.TryParse(Console.ReadLine(), out b)))
                        { Console.WriteLine("Ошибка. Введите число"); }

                        double function = (Math.Pow(Math.Cos(pi), 7) + Math.Sqrt(Math.Log(Math.Pow(b, 4)))) / Math.Pow(Math.Sin((pi / 2) + a), 2);

                        while (hypot != Math.Round(function, 2) && counter < 3)
                        {
                            Console.WriteLine("Попыток осталось: " + (3 - counter));
                            
                            Console.Write("Введите ответ: ");
                            while ((!double.TryParse(Console.ReadLine(), out hypot)))
                            { Console.WriteLine("Ошибка. Введите число"); }
                            
                            if (counter >= 3)
                            {
                                Console.WriteLine($"Вы проиграли. Правильный ответ: {Math.Round(function, 2)}");
                            }
                            
                            if (hypot == Math.Round(function, 2))
                            {
                                Console.WriteLine("Ответ верный. Вы победили!");
                            }
                            else
                            {
                                ++counter;
                                Console.WriteLine("Ответ неверный, попробуйте еще раз");
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("Гаврилов Дмитрий Сергеевич 6101-090301D"); start = false; break;

                    case "3":
                        bool confirm = true;
                        while (confirm)
                        {
                            Console.WriteLine("Вы уверены, что хотите выйти? (д/н)");
                            string answer = Console.ReadLine();
                            switch (answer)
                            {
                                case "д":
                                    start = false; confirm = false; break;
                                case "н":
                                    confirm = false; break;
                                default:
                                    Console.WriteLine("Некорректный ввод, попробуйте снова."); break;
                            }
                        } break;

                    case "4":


                    default:
                        Console.WriteLine("Некорректный ввод, попробуйте снова."); break;
                }
            }
        }
    }
}
