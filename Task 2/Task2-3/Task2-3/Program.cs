namespace Task2_3
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список формальных параметров.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("=== Пересечение двух отрезков ===");

            double a = GetNumber("Введите начало первого отрезка (a): ");
            double b = GetNumber("Введите конец первого отрезка (b): ");
            double c = GetNumber("Введите начало второго отрезка (c): ");
            double d = GetNumber("Введите конец второго отрезка (d): ");

            if (a > b || c > d)
            {
                Console.WriteLine("Начало отрезка не может быть больше его конца.");
            }
            else
            {
                string result = GetIntersectionResult(a, b, c, d);
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Проверка веденного числа на корректность
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

                // Проверка на корректность ввода
                if (double.TryParse(input, out number))
                {
                    return number;
                }
                Console.WriteLine("Некрректно веденно число.");
            }
        }

        /// <summary>
        /// Находим координаты пересечения двух отрезков и точку пересечения
        /// </summary>
        /// <param name="a">Начало первого отрезка.</param>
        /// <param name="b">Конец первого отрезка.</param>
        /// <param name="c">Начало второго отрезка.</param>
        /// <param name="d">Конец второго отрезка.</param>
        /// <returns>Строка с результатом пересечения.</returns>
        static string GetIntersectionResult(double a, double b, double c, double d)
        {
            double left = Math.Max(a, c);
            double right = Math.Min(b, d);
            const double epsilon = 1e-9;

            if (left > right + epsilon)
            {
                return "Отрезки не пересекаются.";
            }
            else if (Math.Abs(left - right) < epsilon)
            {
                return $"Отрезки пересекаются в точке: x = {left}";
            }
            else
            {
                return $"Отрезки пересекаются. Отрезок пересечения: [{left}; {right}]";
            }
        }
    }
}
