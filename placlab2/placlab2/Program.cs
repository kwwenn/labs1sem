using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Program
{
    static bool Exit()
    {

        while (true)
        {
            try
            {
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "д":
                        return true;
                    case "н":
                        return false;
                    default:
                        Console.WriteLine("Некорректный ввод, попробуйте снова. (д/н)");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при вводе: {ex.Message}. Попробуйте снова. (д/н)");
            }
        }
    }
    static double ValidValue(double min, double max)
    {
        double value;
        while (true)
        {
            try
            {
                if (!(double.TryParse(Console.ReadLine(), out value)))
                    throw new ArgumentException("Значение не является числом", nameof(value));
                if (value < min)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"Введите значение не меньше {min}.");
                if (value > max)
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"Введите значение не больше {max}.");
                return value;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка. {ex.Message}");

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка. {ex.Message}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при валидации: {ex.Message}");

            }
        }
    }
    static void Main(string[] args)
    {
        const double waterRate = 59.80;
        const double electricityRate = 5.48;
        const double gasRate = 9.91;
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Калькулятор ЖКХ ===\n 1. Рассчитать платеж\n 2. Выйти");
                string menu = Console.ReadLine();
                    switch (menu)
                    {

                        case "1":
                            bool isCalc = true;
                            while (isCalc)
                            {
                                try
                                {
                                    double water;
                                    double electricity;
                                    double gas;
                                    int month;
                                    double penalty = 1;

                                    Console.Write("Введите расход воды (м³): ");
                                    water = ValidValue(0, 1000);

                                    Console.Write("Введите расход газа (м³): ");
                                    electricity = ValidValue(0, 1000);

                                    Console.Write("Введите расход электроэнергии (кВт·ч): ");
                                    gas = ValidValue(0, 1000);

                                    
                                    bool isBenefits = false;
                                    bool isPensDisc = false;
                                    bool isChildDisc = false;
                                    bool isDisDisc = false;
                                    while (!isBenefits)
                                    {
                                        Console.WriteLine("Есть ли льготы? (1-пенсионер, 2-многодетные, 3-инвалид, 0-нет)");
                                        string benefits = Console.ReadLine();
                                        try
                                        {
                                            switch (benefits)
                                            {
                                                case "1":
                                                    electricity = electricity * 0.7;
                                                    isPensDisc = true;
                                                    isBenefits = true;
                                                    break;
                                                case "2":
                                                    water = water * 0.8;
                                                    gas = gas * 0.8;
                                                    isChildDisc = true;
                                                    isBenefits = true;
                                                    break;
                                                case "3":
                                                    water = water * 0.5;
                                                    gas = gas * 0.5;
                                                    electricity = electricity * 0.5;
                                                    isDisDisc = true;
                                                    isBenefits = true;
                                                    break;
                                                case "0":
                                                    isBenefits = true;
                                                    break;
                                                default:
                                                    throw new ArgumentException("Некорректный ввод. Попробуйте снова");
                                            }
                                        }
                                        catch (ArgumentException ex)
                                        {
                                            Console.WriteLine(ex.Message);
                                        }
                                    }

                                    Console.WriteLine("Сколько месяцев у вас задолжность? (Введите 0 если у вас её нет): ");
                                    month = (int)ValidValue(0, double.PositiveInfinity);
                                    if (month == 0) { }
                                    if (month == 1) { penalty = 1.05; }
                                    else { if (month > 1) penalty = 1.1; }

                                    double sumWater = waterRate * water * penalty;
                                    double sumElectricity = electricityRate * electricity * penalty;
                                    double sumGas = gasRate * gas * penalty;
                                    double check = sumWater + sumElectricity + sumGas;

                            if (isDisDisc)
                            {
                                Console.WriteLine("\n=== Результат ===");
                                Console.WriteLine($"Вода: {Math.Round(sumWater, 2)} (Скидка 50%)");
                                Console.WriteLine($"Газ: {Math.Round(sumGas, 2)} (Скидка 50%)");
                                Console.WriteLine($"Электричество: {Math.Round(sumElectricity, 2)} (Скидка 50%)");
                                Console.WriteLine($"Общая сумма: {Math.Round(check, 2)} ");
                                
                            }
                            else if (isPensDisc)
                            {
                                Console.WriteLine("\n=== Результат ===");
                                Console.WriteLine($"Вода: {Math.Round(sumWater, 2)}");
                                Console.WriteLine($"Газ: {Math.Round(sumGas, 2)}");
                                Console.WriteLine($"Электричество: {Math.Round(sumElectricity, 2)} (Скидка 30%)");
                                Console.WriteLine($"Общая сумма: {Math.Round(check, 2)} ");
                            }
                            else if (isChildDisc)
                            {
                                Console.WriteLine("\n=== Результат ===");
                                Console.WriteLine($"Вода: {Math.Round(sumWater, 2)}  (Скидка 20%)");
                                Console.WriteLine($"Газ: {Math.Round(sumGas, 2)}  (Скидка 20%)");
                                Console.WriteLine($"Электричество: {Math.Round(sumElectricity, 2)}");
                                Console.WriteLine($"Общая сумма: {Math.Round(check, 2)} ");
                            }
                            else
                            {
                                Console.WriteLine("\n=== Результат ===");
                                Console.WriteLine($"Вода: {Math.Round(sumWater, 2)}");
                                Console.WriteLine($"Газ: {Math.Round(sumGas, 2)}");
                                Console.WriteLine($"Электричество: {Math.Round(sumElectricity, 2)}");
                                Console.WriteLine($"Общая сумма: {Math.Round(check, 2)} ");
                            }
                                bool isAgain = true;
                                    while (isAgain)
                                    {
                                        Console.WriteLine("\n\nЧто вы хотите сделать?\n1. Новый расчет\n2. Вернуться в меню");
                                        string again = Console.ReadLine();
                                        switch (again)
                                        {
                                            case "1":
                                                isAgain = false;
                                                break;
                                            case "2":
                                                isCalc = false; isAgain = false; break;
                                            default:
                                                Console.WriteLine("Некорректный ввод. Попробуйте снова");
                                                break;

                                        }
                                    }
                                }
                                catch (Exception exCalc)
                                {
                                    Console.WriteLine($"\nПроизошла ошибка в расчёте: {exCalc.Message}");
                                    Console.WriteLine("Нажмите любую клавишу чтобы вернуться в меню...");
                                    Console.ReadKey();
                                    isCalc = false;
                                }
                                finally
                                {
                                    Console.WriteLine("\nСпасибо за использование калькулятора!  Не забывайте оплачивать коммуналку вовремя!");
                                    Console.ReadKey();
                                }
                            }
                            break;
                        case "2":
                            Console.WriteLine("\nВы уверены что хотите выйти? (д/н)");
                            exit = Exit();
                            break;
                        default:
                            Console.WriteLine("\n\nНекорректный ввод. Для выхода в меню нажмите любую клавишу...");
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }
   

 