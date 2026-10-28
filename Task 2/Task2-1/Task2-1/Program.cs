namespace Task2_1
{
    class Program
    {
        // Перечисляемый тип для выбора действия
        public enum LineType
        {
            Median,     // Медиана
            Bisector    // Биссектриса
        }

        internal static class Program
        {
            /// <summary>
            /// Точка входа в программу.
            /// </summary>
            /// <param name="args">Список формальных параметров.</param>
            static void Main(string[] args)
            {
                Console.WriteLine("Выберите, что нужно найти:");
                Console.WriteLine("1 - Медиану");
                Console.WriteLine("2 - Биссектрису");
                Console.Write("Ваш выбор: ");

                int choice = int.Parse(Console.ReadLine());
                LineType type = (choice == 2) ? LineType.Bisector : LineType.Median;

                double a = GetNumber("Введите сторону a: ");
                double b = GetNumber("Введите сторону b: ");
                double c = GetNumber("Введите сторону c (к которой проводится линия): ");

                // Проверка на существование треугольника
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    Console.WriteLine("Ошибка: Треугольник с такими сторонами не существует!");
                }
                else
                {
                    double result = CalculateLine(a, b, c, type);
                    string lineName = (type == LineType.Median) ? "Медиана" : "Биссектриса";
                    Console.WriteLine($"{lineName} равна: {result:F4}");
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
            /// Вычисляет длину медианы или биссектрисы, проведённой к стороне c.
            /// </summary>
            /// <param name="a">Первая сторона треугольника.</param>
            /// <param name="b">Вторая сторона треугольника.</param>
            /// <param name="c">Сторона, к которой проводится линия.</param>
            /// <param name="type">Тип вычисляемой линии (Медиана или Биссектриса).</param>
            /// <returns>Длина медианы или биссектрисы.</returns>
            static double CalculateLine(double a, double b, double c, LineType type)
            {
                if (type == LineType.Median)
                {
                    // Формула медианы: 0.5 * sqrt(2a^2 + 2b^2 - c^2)
                    return 0.5 * Math.Sqrt(2 * a * a + 2 * b * b - c * c);
                }
                else
                {
                    // Формула биссектрисы: sqrt(a * b - a * b * (c^2 / (a + b)^2))
                    return Math.Sqrt(a * b - a * b * (c * c / Math.Pow(a + b, 2)));
                }
            }
        }
    }
}