namespace Task2_2
{
    internal static class Program
    {        
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список формальных параметров.</param>
            static void Main(string[] args)
            {
                double a = GetNumber("Введите число a: ");
                double b = GetNumber("Введите число b: ");

                SortTwoNumbers(ref a, ref b);

                Console.WriteLine($"Результат: a = {a}, b = {b}");
                Console.ReadLine();
            }

            /// <summary>
            /// Получает число с клавиатуры с проверкой на корректность ввода.
            /// </summary>
            /// <param name="message">Сообщение пользователю.</param>
            /// <returns>Введенное число.</returns>
            static double GetNumber(string message = "")
            {
                double number;
                while (true)
                {
                    Console.Write(message);
                    string input = Console.ReadLine();

                    // Проверка что вели число
                    if (double.TryParse(input, out number))
                    {
                        return number;
                    }
                    Console.WriteLine("Некорректно веденно число число.");
                }
            }

            /// <summary>
            /// Сортировка двух чисел по возрастанию
            /// </summary>
            /// <param name="a">Ссылка на первое число.</param>
            /// <param name="b">Ссылка на второе число.</param>
            static void SortTwoNumbers(ref double a, ref double b)
            {
                if (a > b)
                {
                    double temp = a;
                    a = b;
                    b = temp;
                }
            }
    }
}
