using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    const double WATER_RATE = 59.80;
    const double ELECTRICITY_RATE = 5.48;
    const double GAS_RATE = 9.91;


    static double[] waterConsumptions = new double[6];
    static double[] gasConsumptions = new double[6];
    static double[] electricityConsumptions = new double[6];
    static double[] totalPayments = new double[6];
    static DateTime[] paymentDates = new DateTime[6];
    static int currentPaymentIndex = 0;
    static bool isArrayFull = false;

    static DateTime nextPaymentDate = DateTime.Now;


    static double ValidValue(double min, double max)
    {
        double value;
        while (true)
        {
            try
            {
                if (!double.TryParse(Console.ReadLine(), out value))
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

    static double CalculateUtilityPayment(double rate, double consumption, double penalty = 1)
    {
        return rate * consumption * penalty;
    }


    static (double water, double gas, double electricity) ApplyDiscount(
        double water, double gas, double electricity, string discountType)
    {
        switch (discountType)
        {
            case "1": // пенсионер
                electricity *= 0.7;
                break;
            case "2": // многодетные
                water *= 0.8;
                gas *= 0.8;
                break;
            case "3": // инвалид
                water *= 0.5;
                gas *= 0.5;
                electricity *= 0.5;
                break;
        }
        return (water, gas, electricity);
    }

    static double ApplyPenalty(int months)
    {
        if (months == 0) return 1;
        if (months == 1) return 1.05;
        return 1.1;
    }

    static void SavePaymentToHistory(double water, double gas, double electricity, double totalPayment)
    {
        waterConsumptions[currentPaymentIndex] = water;
        gasConsumptions[currentPaymentIndex] = gas;
        electricityConsumptions[currentPaymentIndex] = electricity;
        totalPayments[currentPaymentIndex] = totalPayment;
        paymentDates[currentPaymentIndex] = nextPaymentDate;

        nextPaymentDate = nextPaymentDate.AddMonths(1);

        currentPaymentIndex++;
        if (currentPaymentIndex >= 6)
        {
            currentPaymentIndex = 0;
            isArrayFull = true;
        }
    }

    static void ShowPaymentHistory()
    {
        Console.WriteLine("\n=== История платежей ===");

        if (!isArrayFull && currentPaymentIndex == 0)
        {
            Console.WriteLine("История платежей пуста.");
            return;
        }

        int totalRecords = isArrayFull ? 6 : currentPaymentIndex;

        Console.WriteLine($"{"Дата",-12} {"Вода, м3",-10} {"Газ, м3",-10} {"Эл-во, кВт·ч",-15} {"Сумма, руб",-12}");
        Console.WriteLine(new string('-', 62));

        for (int i = 0; i < totalRecords; i++)
        {
            int index = isArrayFull ? (currentPaymentIndex + i) % 6 : i;
            Console.WriteLine($"{paymentDates[index]:MM/yyyy} {waterConsumptions[index],9:F1} " +
                            $"{gasConsumptions[index],9:F1} {electricityConsumptions[index],14:F1} " +
                            $"{totalPayments[index],11:F2}");
        }
    }

    static void AnalyzeConsumption()
    {
        Console.WriteLine("\n=== Анализ потребления ===");

        if (!isArrayFull && currentPaymentIndex == 0)
        {
            Console.WriteLine("Недостаточно данных для анализа.");
            return;
        }

        int totalRecords = isArrayFull ? 6 : currentPaymentIndex;

        double avgWater = waterConsumptions.Take(totalRecords).Average();
        double avgGas = gasConsumptions.Take(totalRecords).Average();
        double avgElectricity = electricityConsumptions.Take(totalRecords).Average();

        Console.WriteLine($"Средний расход за {totalRecords} месяцев:");
        Console.WriteLine($"Вода: {avgWater:F1} м3");
        Console.WriteLine($"Газ: {avgGas:F1} м3");
        Console.WriteLine($"Электричество: {avgElectricity:F1} кВт·ч");

        if (totalRecords > 0)
        {
            int maxWaterIndex = Array.IndexOf(waterConsumptions.Take(totalRecords).ToArray(), waterConsumptions.Take(totalRecords).Max());
            int maxGasIndex = Array.IndexOf(gasConsumptions.Take(totalRecords).ToArray(), gasConsumptions.Take(totalRecords).Max());
            int maxElectricityIndex = Array.IndexOf(electricityConsumptions.Take(totalRecords).ToArray(), electricityConsumptions.Take(totalRecords).Max());

            Console.WriteLine($"\nМаксимальное потребление:");
            Console.WriteLine($"Вода: {waterConsumptions[maxWaterIndex]:F1} м3 ({paymentDates[maxWaterIndex]:MMMM yyyy})");
            Console.WriteLine($"Газ: {gasConsumptions[maxGasIndex]:F1} м3 ({paymentDates[maxGasIndex]:MMMM yyyy})");
            Console.WriteLine($"Электричество: {electricityConsumptions[maxElectricityIndex]:F1} кВт·ч ({paymentDates[maxElectricityIndex]:MMMM yyyy})");

            int minPaymentIndex = Array.IndexOf(totalPayments.Take(totalRecords).ToArray(), totalPayments.Take(totalRecords).Min());
            int maxPaymentIndex = Array.IndexOf(totalPayments.Take(totalRecords).ToArray(), totalPayments.Take(totalRecords).Max());

            Console.WriteLine($"\nСамый экономный месяц: {paymentDates[minPaymentIndex]:MMMM yyyy} ({totalPayments[minPaymentIndex]:F2} руб)");
            Console.WriteLine($"Самый затратный месяц: {paymentDates[maxPaymentIndex]:MMMM yyyy} ({totalPayments[maxPaymentIndex]:F2} руб)");
        }
    }

    static void CompareWithPreviousMonth()
    {
        if (currentPaymentIndex < 2 && !isArrayFull)
        {
            Console.WriteLine("Недостаточно данных для сравнения (нужно как минимум 2 записи).");
            return;
        }

        int currentIndex = currentPaymentIndex == 0 ? 5 : currentPaymentIndex - 1;
        int previousIndex = currentIndex == 0 ? 5 : currentIndex - 1;

        Console.WriteLine("\n=== Сравнение с предыдущим месяцем ===");
        Console.WriteLine($"Текущий месяц: {paymentDates[currentIndex]:MMMM yyyy}");
        Console.WriteLine($"Предыдущий месяц: {paymentDates[previousIndex]:MMMM yyyy}");

        double waterChange = ((waterConsumptions[currentIndex] - waterConsumptions[previousIndex]) / waterConsumptions[previousIndex]) * 100;
        double gasChange = ((gasConsumptions[currentIndex] - gasConsumptions[previousIndex]) / gasConsumptions[previousIndex]) * 100;
        double electricityChange = ((electricityConsumptions[currentIndex] - electricityConsumptions[previousIndex]) / electricityConsumptions[previousIndex]) * 100;
        double totalChange = ((totalPayments[currentIndex] - totalPayments[previousIndex]) / totalPayments[previousIndex]) * 100;

        Console.WriteLine($"\nИзменение потребления:");
        Console.WriteLine($"Вода: {waterChange:+#.##;-#.##;0}%");
        Console.WriteLine($"Газ: {gasChange:+#.##;-#.##;0}%");
        Console.WriteLine($"Электричество: {electricityChange:+#.##;-#.##;0}%");
        Console.WriteLine($"Общая сумма: {totalChange:+#.##;-#.##;0}%");
    }

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("=== Калькулятор ЖКХ ===");
            Console.WriteLine("1. Новый расчёт");
            Console.WriteLine("2. История платежей");
            Console.WriteLine("3. Анализ потребления");
            Console.WriteLine("4. Сравнить с предыдущим месяцем");
            Console.WriteLine("5. Выйти");
            Console.Write("Выберите действие: ");

            string menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    CalculateNewPayment();
                    break;
                case "2":
                    ShowPaymentHistory();
                    WaitForUser();
                    break;
                case "3":
                    AnalyzeConsumption();
                    WaitForUser();
                    break;
                case "4":
                    CompareWithPreviousMonth();
                    WaitForUser();
                    break;
                case "5":
                    // Добавляем подтверждение выхода
                    if (ConfirmExit())
                    {
                        Console.WriteLine("Выход из программы...");
                        exit = true;
                    }
                    break;
                default:
                    Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                    WaitForUser();
                    break;
            }
        }
    }

    // Новая функция для подтверждения выхода
    static bool ConfirmExit()
    {
        while (true)
        {
            Console.Write("Вы уверены, что хотите выйти? (д/н): ");
            string response = Console.ReadLine()?.ToLower();

            if (response == "д")
            {
                return true;
            }
            else if (response == "н")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите 'д' для выхода или 'н' для отмены.");
            }
        }
    }

    static void CalculateNewPayment()
    {
        bool isCalc = true;
        while (isCalc)
        {
            try
            {
                Console.WriteLine($"\nРасчёт за {nextPaymentDate:MMMM yyyy}:");

                Console.Write("Введите расход воды (м3): ");
                double water = ValidValue(0, 1000);

                Console.Write("Введите расход газа (м3): ");
                double gas = ValidValue(0, 1000);

                Console.Write("Введите расход электроэнергии (кВт·ч): ");
                double electricity = ValidValue(0, 1000);


                bool isBenefits = false;
                bool isPensDisc = false;
                bool isChildDisc = false;
                bool isDisDisc = false;

                while (!isBenefits)
                {
                    Console.WriteLine("Есть ли льготы? (1-пенсионер, 2-многодетные, 3-инвалид, 0-нет)");
                    string benefits = Console.ReadLine();

                    switch (benefits)
                    {
                        case "1":
                            (water, gas, electricity) = ApplyDiscount(water, gas, electricity, benefits);
                            isPensDisc = true;
                            isBenefits = true;
                            break;
                        case "2":
                            (water, gas, electricity) = ApplyDiscount(water, gas, electricity, benefits);
                            isChildDisc = true;
                            isBenefits = true;
                            break;
                        case "3":
                            (water, gas, electricity) = ApplyDiscount(water, gas, electricity, benefits);
                            isDisDisc = true;
                            isBenefits = true;
                            break;
                        case "0":
                            isBenefits = true;
                            break;
                        default:
                            Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                            break;
                    }
                }


                Console.Write("Сколько месяцев у вас задолженность? (Введите 0 если у вас её нет): ");
                int month = (int)ValidValue(0, 100);
                double penalty = ApplyPenalty(month);

                double sumWater = CalculateUtilityPayment(WATER_RATE, water, penalty);
                double sumGas = CalculateUtilityPayment(GAS_RATE, gas, penalty);
                double sumElectricity = CalculateUtilityPayment(ELECTRICITY_RATE, electricity, penalty);
                double total = sumWater + sumGas + sumElectricity;

                Console.WriteLine("\n=== Результат ===");
                if (isDisDisc)
                {
                    Console.WriteLine($"Вода: {Math.Round(sumWater, 2)} (Скидка 50%)");
                    Console.WriteLine($"Газ: {Math.Round(sumGas, 2)} (Скидка 50%)");
                    Console.WriteLine($"Электричество: {Math.Round(sumElectricity, 2)} (Скидка 50%)");
                }
                else if (isPensDisc)
                {
                    Console.WriteLine($"Вода: {Math.Round(sumWater, 2)}");
                    Console.WriteLine($"Газ: {Math.Round(sumGas, 2)}");
                    Console.WriteLine($"Электричество: {Math.Round(sumElectricity, 2)} (Скидка 30%)");
                }
                else if (isChildDisc)
                {
                    Console.WriteLine($"Вода: {Math.Round(sumWater, 2)} (Скидка 20%)");
                    Console.WriteLine($"Газ: {Math.Round(sumGas, 2)} (Скидка 20%)");
                    Console.WriteLine($"Электричество: {Math.Round(sumElectricity, 2)}");
                }
                else
                {
                    Console.WriteLine($"Вода: {Math.Round(sumWater, 2)}");
                    Console.WriteLine($"Газ: {Math.Round(sumGas, 2)}");
                    Console.WriteLine($"Электричество: {Math.Round(sumElectricity, 2)}");
                }
                Console.WriteLine($"Общая сумма: {Math.Round(total, 2)}");

                SavePaymentToHistory(water, gas, electricity, total);

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
                            isCalc = false;
                            isAgain = false;
                            break;
                        default:
                            Console.WriteLine("Некорректный ввод. Попробуйте снова");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }

    static void WaitForUser()
    {
        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
        Console.ReadKey();
    }
}