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

            // Проверка корректности ввода (начало не должно быть больше конца)
            if (a > b || c > d)
            {
                Console.WriteLine("Ошибка: Начало отрезка не может быть больше его конца.");
            }
            else
            {
                string result = GetIntersectionResult(a, b, c, d);
                Console.WriteLine(result);
            }

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
        /// Находит координаты пересечения двух отрезков или сообщает об их отсутствии.
        /// </summary>
        /// <param name="a">Начало первого отрезка.</param>
        /// <param name="b">Конец первого отрезка.</param>
        /// <param name="c">Начало второго отрезка.</param>
        /// <param name="d">Конец второго отрезка.</param>
        /// <returns>Строка с результатом пересечения.</returns>
        static string GetIntersectionResult(double a, double b, double c, double d)
        {
            // Находим максимальное начало и минимальный конец
            double left = Math.Max(a, c);
            double right = Math.Min(b, d);

            // Если левая граница больше правой, отрезки не пересекаются
            if (left > right)
            {
                return "Отрезки не пересекаются.";
            }
            // Если границы равны, пересечение — это точка
            else if (left == right)
            {
                return $"Отрезки пересекаются в точке: x = {left}";
            }
            // Иначе пересечение — это отрезок
            else
            {
                return $"Отрезки пересекаются. Отрезок пересечения: [{left}; {right}]";
            }
        }
    }
}
