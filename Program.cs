using System;

namespace GitHubSecurityDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("GitHub Security Demo");
                Console.WriteLine();
                Console.WriteLine("1. Показати інформацію про програму");
                Console.WriteLine("2. Виконати тестову операцію");
                Console.WriteLine("3. Вийти");
                Console.Write("Виберіть опцію: ");

                var choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        ShowInfo();
                        break;
                    case "2":
                        RunTestOperation();
                        break;
                    case "3":
                        Console.WriteLine("Вихід...");
                        return;
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }

        private static void ShowInfo()
        {
            Console.WriteLine("Цей проєкт створений для демонстрації безпечної роботи з GitHub.");
        }

        private static void RunTestOperation()
        {
            Console.WriteLine("Тестова операція: складання двох чисел.");

            double a = ReadDoubleFromConsole("Введіть перше число: ");
            double b = ReadDoubleFromConsole("Введіть друге число: ");

            double sum = a + b;
            Console.WriteLine($"Результат: {a} + {b} = {sum}");
        }

        private static double ReadDoubleFromConsole(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine();
                if (double.TryParse(input, out var value))
                {
                    return value;
                }

                Console.WriteLine("Недійсне число. Спробуйте ще раз.");
            }
        }
    }
}
