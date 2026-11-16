namespace Task1_1
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список формальных параметров.</param>
        static void Main(string[] args)
        {
            const double a = 2;
            const double b = 1;
            const double c = 3;

            double x = GetNumber("Введите x = ");
            double y = GetResult(a, b, c, x);

            Console.WriteLine($"x = {x}; y = {y:F4}");
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
        /// Получает расчёт функции.
        /// </summary>
        /// <param name="a">Константа a.</param>
        /// <param name="b">Константа b.</param>
        /// <param name="c">Константа c.</param>
        /// <param name="x">Переменная x.</param>
        /// <returns>Значение функции.</returns>
        static double GetResult(double a, double b, double c, double x)
        {
            // Числитель: (3/4)*a * sqrt(x^2 + b*|x|) + c
            double numerator = (3.0 / 4.0) * a * Math.Sqrt(x * x + b * Math.Abs(x)) + c;

            // Знаменатель: x^2 + sin(x)
            double denominator = x * x + Math.Sin(x);

            return numerator / denominator;
        }
    }
}
