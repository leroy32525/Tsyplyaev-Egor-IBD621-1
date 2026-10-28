namespace Task2_1
{
        class Program
        {
            static void Main(string[] args)
            {
            /// <summary>
            /// Запрос данных у пользователя
            ///  </summary>
            Console.Write("Введите длину стороны a: ");
                double a = Convert.ToDouble(Console.ReadLine()); /// Запрос длины стороны a

                Console.Write("Введите длину стороны b: ");
                double b = Convert.ToDouble(Console.ReadLine()); ///  Запрос длины стороны b

            Console.Write("Введите длину стороны c: ");
                double c = Convert.ToDouble(Console.ReadLine()); ///  Запрос длины стороны c

            /// Проверка существует ли такой треугольник с такими сторонами
            if (a + b > c && a + c > b && b + c > a)
                {
                    ///Вычисляем длину медианы 
                    double median = 0.5 * Math.Sqrt(2 * Math.Pow(a, 2) + 2 * Math.Pow(b, 2) - Math.Pow(c, 2));

                    /// Вычисляем длину биссектрисы
                    double bisector = Math.Sqrt(a * b * (a + b + c) * (a + b - c)) / (a + b);

                    /// Вывод результата вычесления
                    Console.WriteLine("\n--- Результаты вычислений ---");
                    Console.WriteLine($"Длина медианы к стороне c: {Math.Round(median, 4)}");
                    Console.WriteLine($"Длина биссектрисы к стороне c: {Math.Round(bisector, 4)}");
                }
                else
                {
                    /// Вывод ошибки если по результата такого треугольника не существует
                    Console.WriteLine("\nОшибка: Треугольник с такими сторонами не существует!");
                }
            }
        }
}
