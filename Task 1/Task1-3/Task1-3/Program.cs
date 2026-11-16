namespace Task1_3
{
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список формальных параметров.</param>
        static void Main(string[] args)
        {
            double u = GetNumber("Введите напряжение U (В): ");
            double r = GetNumber("Введите сопротивление R (Ом): ");
            double t = GetNumber("Введите время t (с): ");

            if (r == 0)
            {
                Console.WriteLine("Ошибка: Сопротивление не может быть равно нулю!");
            }
            else
            {
                double q = GetCharge(u, r, t);
                Console.WriteLine($"Заряд q = {q:F4} Кл");
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
        /// Вычисляет заряд, прошедший через проводник.
        /// </summary>
        /// <param name="u">Напряжение (В).</param>
        /// <param name="r">Сопротивление (Ом).</param>
        /// <param name="t">Время (с).</param>
        /// <returns>Значение заряда (Кл).</returns>
        static double GetCharge(double u, double r, double t)
        {
            return (u / r) * t;
        }
    }
}

