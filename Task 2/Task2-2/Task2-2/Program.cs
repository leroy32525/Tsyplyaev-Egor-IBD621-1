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

            // Вызываем функцию сортировки, передавая переменные по ссылке
            SortTwoNumbers(ref a, ref b);

            Console.WriteLine($"Результат: a = {a}, b = {b}");
            Console.ReadLine();
        }

        /// <summary>
        /// Получает число.
        /// </summary>
        /// <param name="message">Сообщение пользователю.</param>
        /// <returns>Число, введенное с клавиатуры.</returns>
        static double GetNumber(string message = "")
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return double.Parse(input);
        }

        /// <summary>
        /// Сортирует два числа по возрастанию. Если первое число больше второго,
        /// они меняются местами с использованием третьей переменной.
        /// </summary>
        /// <param name="a">Ссылка на первое число.</param>
        /// <param name="b">Ссылка на второе число.</param>
        static void SortTwoNumbers(ref double a, ref double b)
        {
            if (a > b)
            {
                // Обмен значений через третью переменную
                double temp = a;
                a = b;
                b = temp;
            }
        }
    }
}
