using _5lab;
using System;

namespace _3lab
{


    /// <summary>
    /// Основной класс программы, содержащий точку входа
    /// </summary>
    internal class Program
    {

        /// <summary>
        /// Выводит информацию об авторе
        /// </summary>
        private static void DisplayAuthorInfo()
        {
            Console.WriteLine("Гаврилов Дмитрий Сергеевич 6101-090301D");
        }

        /// <summary>
        /// Демонстрирует работу с массивами и сортировками
        /// </summary>
        private static void DemonstrateArraySorting()
        {
            Console.WriteLine("Введите длину массива:");
            int customLength = InputValidator.GetLenIntInput();
            ArrayWorker customArray = new ArrayWorker(customLength);

            ArrayWorker defaultArray = new ArrayWorker();

            Console.WriteLine("\n--- Работа с массивом, созданным конструктором с параметрами ---");
            PerformSorting(customArray);

            Console.WriteLine("\n--- Работа с массивом, созданным конструктором без параметров ---");
            PerformSorting(defaultArray);
        }

        /// <summary>
        /// Выполняет сортировку массива и выводит результаты
        /// </summary>
        /// <param name="arrayWorker">Экземпляр класса ArrayWorker</param>
        private static void PerformSorting(ArrayWorker arrayWorker)
        {
            Console.WriteLine("Исходный массив:");
            arrayWorker.PrintArray();

            int[] originalArray = arrayWorker.CopyArray();

            double bubbleSortTime = arrayWorker.BubbleSort();
            Console.WriteLine($"Время выполнения сортировки пузырьком: {bubbleSortTime:F6} мс");

            ArrayWorker tempWorker = new ArrayWorker(originalArray.Length);

            for (int i = 0; i < originalArray.Length; i++)
            {
                tempWorker.Array[i] = originalArray[i];
            }

            double shellSortTime = arrayWorker.ShellSort();
            Console.WriteLine($"Время выполнения сортировки Шелла: {shellSortTime:F6} мс");

            if (arrayWorker.Length <= 10)
            {
                Console.WriteLine("Отсортированный массив:");
                arrayWorker.PrintArray();
            }
            else
            {
                Console.WriteLine("Массивы слишком длинные для отображения");
            }
        }

        /// <summary>
        /// Запускает игру "4 в ряд"
        /// </summary>
        private static void PlayConnectFour()
        {
            bool playAgain;
            do
            {
                ConnectFourGame game = new ConnectFourGame();
                game.Play();

                Console.WriteLine("Вы хотите начать новую игру? (д/н)");
                playAgain = InputValidator.GetExitConfirmation();
            } while (!playAgain);

            Console.WriteLine("\nСпасибо за игру! До свидания!");
        }
    
        
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Меню:\n 1. Отгадай ответ\n 2. Об авторе\n 3. Сортировка массивов\n 4. Игра\n 5. Выход");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        FunctionGame.PlayGame();
                        Console.WriteLine("\n\nНажмите любую клавишу, чтобы вернуться в меню.");
                        Console.ReadKey();
                        break;

                    case "2":
                        DisplayAuthorInfo();
                        Console.WriteLine("\n\nНажмите любую клавишу, чтобы вернуться в меню.");
                        Console.ReadKey();
                        break;

                    case "3":
                        DemonstrateArraySorting();
                        Console.WriteLine("\n\nНажмите любую клавишу, чтобы вернуться в меню.");
                        Console.ReadKey();
                        break;

                    case "4":
                        PlayConnectFour();
                        Console.WriteLine("\n\nНажмите любую клавишу, чтобы вернуться в меню.");
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Вы уверены, что хотите выйти? (д/н)");
                        running = InputValidator.GetExitConfirmation();
                        break;

                    default:
                        Console.WriteLine("Некорректный ввод, попробуйте снова.");
                        Console.ReadKey();
                        break;
                }
            }
        }

    }
}