using System;

namespace _5lab
{
    /// <summary>
    /// Статический класс, содержащий методы для игры по отгадыванию ответа значения функции
    /// </summary>
    public static class FunctionGame
    {
        /// <summary>
        /// Вычисляет значение функции по заданным параметрам
        /// </summary>
        /// <param name="a">Первый параметр функции</param>
        /// <param name="b">Второй параметр функции</param>
        /// <returns>Результат вычисления функции</returns>
        public static double CalculateFunction(int a, int b)
        {
            const double pi = Math.PI;
            return (Math.Pow(Math.Cos(pi), 7) + Math.Sqrt(Math.Log(Math.Pow(b, 4)))) /
                   Math.Pow(Math.Sin((pi / 2) + a), 2);
        }

        /// <summary>
        /// Запускает игру по отгадыванию значения функции
        /// </summary>
        public static void PlayGame()
        {
            Console.Write("Введите а: ");
            int a = InputValidator.GetIntInput();

            Console.Write("Введите b: ");
            int b = InputValidator.GetIntInput();

            double function = CalculateFunction(a, b);
            GuessFunctionValue(function);
        }

        private static void GuessFunctionValue(double functionValue)
        {
            double userGuess = 0;
            int counter = 0;
            double roundedValue = Math.Round(functionValue, 2);

            while (userGuess != roundedValue && counter < 3)
            {
                Console.WriteLine("Попыток осталось: " + (3 - counter));
                Console.Write("Введите ответ: ");
                userGuess = InputValidator.GetDoubleInput();

                if (userGuess == roundedValue)
                {
                    Console.WriteLine("Ответ верный. Вы победили!");
                    return;
                }
                else
                {
                    ++counter;
                    Console.WriteLine("Ответ неверный, попробуйте еще раз");
                }
            }

            if (counter >= 3)
            {
                Console.WriteLine($"Вы проиграли. Правильный ответ: {roundedValue}");
            }
        }
    }
}