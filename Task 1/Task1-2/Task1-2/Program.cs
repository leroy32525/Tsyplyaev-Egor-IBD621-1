namespace Task1_2
{
    {
        class Program
        {
        /// <param name="args"> Список формальных параметров. </param >
        static void Main(string[] args)
            {
            /// <summary>
            /// Ввод данных
            /// </summary>
            Console.Write("Введите число a: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите число b: ");
                double b = Convert.ToDouble(Console.ReadLine());
            /// <summary>
            ///Вычисления
            /// </summary>
            /// <summary>
            /// Вычесление квадрата
            /// </summary>
            double sumOfSquares = Math.Pow(a, 2) + Math.Pow(b, 2);
            /// <summary>
            /// Квадрат суммы: (a + b)^2
            /// </summary>
            double squareOfSum = Math.Pow(a + b, 2);
            /// <summary>
            ///Вывод результатов
            /// </summary>
            Console.WriteLine($"\nСумма квадратов (a² + b²) = {sumOfSquares}");
                Console.WriteLine($"Квадрат суммы (a + b)² = {squareOfSum}");
            }
        }
    }
}
