using System;

namespace _3lab
{
    public static class InputValidator
    {
        public static int GetIntInput()
        {
            int number;
            while ((!int.TryParse((Console.ReadLine()), out number)))
            {
                Console.WriteLine("Ошибка. Введите целое число");
            }
            return number;
        }

        public static double GetDoubleInput()
        {
            double number;
            while ((!double.TryParse((Console.ReadLine()), out number)))
            {
                Console.WriteLine("Ошибка. Введите число");
            }
            return number;
        }

        public static int GetLenIntInput()
        {
            int number;
            while ((!int.TryParse((Console.ReadLine()), out number)) || number < 0)
            {
                Console.WriteLine("Ошибка. Введите положительное число");
            }
            return number;
        }

        public static bool GetExitConfirmation()
        {
            while (true)
            {
                string answer = Console.ReadLine();
                switch (answer.ToLower())
                {
                    case "д":
                        return false;
                    case "н":
                        return true;
                    default:
                        Console.WriteLine("Некорректный ввод. Введите 'д' или 'н'");
                        break;
                }
            }
        }
    }
}