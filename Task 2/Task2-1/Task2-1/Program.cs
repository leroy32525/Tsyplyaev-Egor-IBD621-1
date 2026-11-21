namespace Task2_1
{
    
    /// <summary>
    /// Перечисляемый тип для выбора вычисляемой линии
    /// </summary>
    public enum LineType
    {
        /// <summary> Линия не выбрана </summary>
        None,
        /// <summary> Медиана </summary>
        Median,
        /// <summary> Биссектриса </summary>
        Bisector
    }

    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Список формальных параметров</param>
        static void Main(string[] args)
        {
            /// Выводим доступные варианты
            Console.WriteLine($"Выберите, что нужно найти ({LineType.Median} или {LineType.Bisector}):");

            /// Получаем тип данных
            LineType type = GetLineTypeFromUser();

            if (type == LineType.None)
            {
                Console.WriteLine("неверно выбран тип линии.");
                Console.ReadLine();
                return;
            }

            double a = GetNumber("Введите сторону a: ");
            double b = GetNumber("Введите сторону b: ");
            double c = GetNumber("Введите сторону c (к которой проводится линия): ");

            if (!IsTriangleValid(a, b, c))
            {
                Console.WriteLine("Треугольник с такими сторонами не существует!");
            }
            else
            {
                switch (type)
                {
                    case LineType.Median:
                        Console.WriteLine($"{type} равна: {GetMedian(a, b, c):F4}");
                        break;
                    case LineType.Bisector:
                        Console.WriteLine($"{type} равна: {GetBisector(a, b, c):F4}");
                        break;
                }
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Запрашивает у пользователя тип линии
        /// </summary>
        /// <returns>Выбранный тип линии (Median, Bisector или None при ошибке)</returns>
        static LineType GetLineTypeFromUser()
        {
            Console.Write("Ваш выбор: ");
            string input = Console.ReadLine();
            if (Enum.TryParse(input, true, out LineType type) && type != LineType.None)
            {
                return type;
            }

            return LineType.None;
        }

        /// <summary>
        /// Проверяет существование треугольника по трем сторонам.
        /// </summary>
        /// <param name="a">Первая сторона.</param>
        /// <param name="b">Вторая сторона.</param>
        /// <param name="c">Третья сторона.</param>
        /// <returns>True, если треугольник существует, иначе False</returns>
        static bool IsTriangleValid(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        /// <summary>
        /// Получает число с клавиатуры с проверкой на корректность ввода
        /// </summary>
        /// <param name="message">Сообщение пользователю</param>
        /// <returns>Введенное число.</returns>
        static double GetNumber(string message = "")
        {
            double number;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (double.TryParse(input, out number))
                {
                    return number;
                }
                Console.WriteLine("Некорректно веденно число.");
            }
        }

        /// <summary>
        /// Вычисляет длину медианы, проведенной к стороне c
        /// </summary>
        /// <param name="a">Первая сторона.</param>
        /// <param name="b">Вторая сторона.</param>
        /// <param name="c">Сторона, к которой проведена медиана</param>
        /// <returns>Длина медианы.</returns>
        static double GetMedian(double a, double b, double c)
        {
            return 0.5 * Math.Sqrt(2 * a * a + 2 * b * b - c * c);
        }

        /// <summary>
        /// Вычисляет длину биссектрисы, проведенной к стороне c
        /// </summary>
        /// <param name="a">Первая сторона.</param>
        /// <param name="b">Вторая сторона.</param>
        /// <param name="c">Сторона, к которой проведена биссектриса</param>
        /// <returns>Длина биссектрисы.</returns>
        static double GetBisector(double a, double b, double c)
        {
            return Math.Sqrt(a * b - a * b * (c * c / Math.Pow(a + b, 2)));
        }
    }
}