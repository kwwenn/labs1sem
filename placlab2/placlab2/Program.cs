using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    static bool Exit()
    {
        bool confirm = true;
        while (confirm)
        {
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "д":
                    confirm = false;
                    return false;
                case "н":
                    confirm = false;
                    return true;
                default:
                    Console.WriteLine("Некорректный ввод, попробуйте снова. (д/н)");
                    break;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        const double waterRate = 59.80;
        const double electricityRate = 5.48;
        const double gasRate = 9.91;

        bool start = true;
        while(start)
        {
            Console.Clear();
            Console.WriteLine("=== Калькулятор ЖКХ ===\n 1. Рассчитать платеж\n 2. Выйти");
            string menu = Console.ReadLine();
            switch (menu)
            {
                
                case "1":
                    bool calc = true;
                    while (calc)
                    {
                        double water;
                        double electricity;
                        double gas;
                        double penalty = 1;

                        Console.Write("Введите расход воды (м³): ");
                        while ((!double.TryParse((Console.ReadLine()), out water)) || water < 0 || water > 1000)
                        { Console.Write("Ошибка. Введите положительное число не превосходящее 1000: "); }

                        Console.Write("Введите расход газа (м³): ");
                        while ((!double.TryParse((Console.ReadLine()), out electricity)) || electricity < 0 || electricity > 1000)
                        { Console.Write("Ошибка. Введите положительное число не превосходящее 1000: "); }

                        Console.Write("Введите расход электроэнергии (кВт·ч): ");
                        while (!(double.TryParse((Console.ReadLine()), out gas)) || gas < 0 || gas > 5000)
                        { Console.Write("Ошибка. Введите положительное число не превосходящее 5000: "); }

                        bool status = true;
                        while (status)
                        {
                            Console.WriteLine("Есть ли льготы? (1-пенсионер, 2-многодетные, 3-инвалид, 0-нет)");
                            string benefits = Console.ReadLine();
                            switch (benefits)
                            {
                                case "1":
                                    electricity = electricity * 0.7;
                                    status = false;
                                    break;
                                case "2":
                                    water = water * 0.8;
                                    gas = gas * 0.8;
                                    status = false;
                                    break;
                                case "3":
                                    water = water * 0.5;
                                    gas = gas * 0.5;
                                    electricity = electricity * 0.5;
                                    status = false;
                                    break;
                                case "0":
                                    status = false;
                                    break;
                                default:
                                    Console.WriteLine("Некорректный ввод. Попробуйте снова");
                                    break;
                            }
                        }

                        bool status2 = true;
                        while (status2)
                        {
                            int month;
                            Console.WriteLine("Сколько месяцев у вас задолжность? (Введите 0 если у вас её нет): ");
                            while (!(int.TryParse((Console.ReadLine()), out month)) || month < 0)
                            { Console.Write("Ошибка. Введите положительное число: "); }
                            if (month == 0) { status = false; break; }
                            if (month == 1) { penalty = 1.05; status = false; break; }
                            else { penalty = 1.1; status = false; break; }
                        }

                        double sumWater = waterRate * water * penalty;
                        double sumElectricity = electricityRate * electricity * penalty;
                        double sumGas = gasRate * gas * penalty;
                        double check = sumWater + sumElectricity + sumGas;

                        Console.WriteLine("\n=== Результат ===");
                        Console.WriteLine($"Вода: {Math.Round(sumWater, 2)}");
                        Console.WriteLine($"Газ: {Math.Round(sumGas, 2)}");
                        Console.WriteLine($"Электричество: {Math.Round(sumElectricity, 2)}");
                        Console.WriteLine($"Общая сумма: {Math.Round(check, 2)}");
                        Console.WriteLine("\nСпасибо за использование калькулятора!  Не забывайте оплачивать коммуналку вовремя!");

                        bool isAgain = true;
                        while(isAgain)
                        {
                            Console.WriteLine("\n\nЧто вы хотите сделать?\n1. Новый расчет\n2. Вернуться в меню");
                            string again = Console.ReadLine();
                            switch (again)
                            {
                                case "1":
                                    isAgain = false;
                                    break;
                                case "2":
                                    calc = false; isAgain = false; break;
                                default:
                                    Console.WriteLine("Некорректный ввод. Попробуйте снова");
                                    break;
                                    
                            }
                        }
                    }
                    break;
                case "2":                 
                    Console.WriteLine("\nВы уверены что хотите выйти? (д/н)");
                    start = Exit();
                    break;
                default:
                    Console.WriteLine("\n\nНекорректный ввод. Для выхода в меню нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                    
            }
        }
    }
}
