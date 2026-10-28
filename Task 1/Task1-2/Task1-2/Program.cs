namespace Task1_2
{
    {
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список формальных параметров.</param>
        static void Main(string[] args)
        {
            double num1 = GetNumber("Введите первое число: ");
            double num2 = GetNumber("Введите второе число: ");

            double sumOfSquares = GetSumOfSquares(num1, num2);
            double squareOfSum = GetSquareOfSum(num1, num2);

            Console.WriteLine($"Сумма квадратов: {sumOfSquares}");
            Console.WriteLine($"Квадрат суммы: {squareOfSum}");
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
        /// Вычисляет сумму квадратов двух чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Сумма квадратов.</returns>
        static double GetSumOfSquares(double a, double b)
        {
            return (a * a) + (b * b);
        }

        /// <summary>
        /// Вычисляет квадрат суммы двух чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Квадрат суммы.</returns>
        static double GetSquareOfSum(double a, double b)
        {
            return Math.Pow(a + b, 2);
        }
    }
}
}
