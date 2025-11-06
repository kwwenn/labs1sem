using System;

namespace _5lab
{
    /// <summary>
    /// Статический класс для проверки и валидации вводимых данных
    /// </summary>
    public static class InputValidator
    {
        /// <summary>
        /// Получает целое число от пользователя с проверкой корректности
        /// </summary>
        /// <returns>Введенное целое число</returns>
        public static int GetIntInput()
        {
            int number;
            while ((!int.TryParse((Console.ReadLine()), out number)))
            {
                Console.WriteLine("Ошибка. Введите целое число");
            }
            return number;
        }

        /// <summary>
        /// Получает число с плавающей точкой от пользователя с проверкой корректности
        /// </summary>
        /// <returns>Введенное число с плавающей точкой</returns>
        public static double GetDoubleInput()
        {
            double number;
            while ((!double.TryParse((Console.ReadLine()), out number)))
            {
                Console.WriteLine("Ошибка. Введите число");
            }
            return number;
        }

        /// <summary>
        /// Получает положительное целое число от пользователя с проверкой корректности
        /// </summary>
        /// <returns>Введенное положительное целое число</returns>
        public static int GetLenIntInput()
        {
            int number;
            while ((!int.TryParse((Console.ReadLine()), out number)) || number < 0)
            {
                Console.WriteLine("Ошибка. Введите положительное число");
            }
            return number;
        }

        /// <summary>
        /// Получает ответ пользователя (д/н) с проверкой корректности
        /// </summary>
        /// <returns>true - если пользователь ответил "н", false - если "д"</returns>
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