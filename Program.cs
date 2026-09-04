using System;

namespace GitHubSecurityDemo
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Демонстрація безпечної роботи з GitHub");
                Console.WriteLine();
                Console.WriteLine("Оберіть дію:");
                Console.WriteLine("1. Показати інформацію про програму");
                Console.WriteLine("2. Виконати тестову операцію");
                Console.WriteLine("3. Вийти");
                Console.Write("Ваш вибір: ");

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
                        Console.WriteLine("Вихід з програми.");
                        return;
                    default:
                        Console.WriteLine("Помилка: введіть коректне число.");
                        break;
                }
            }
        }

        private static void ShowInfo()
        {
            Console.WriteLine("Цей проєкт написаний мовою C# і призначений для демонстрації безпечної роботи з GitHub.");
        }

        private static void RunTestOperation()
        {
            Console.WriteLine("Тестова операція: додавання двох чисел.");

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

                Console.WriteLine("Помилка: введіть коректне число.");
            }
        }
    }
}
