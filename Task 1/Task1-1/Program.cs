namespace Task1_1
{
    class Program
    {
        /// <param name="args"> Список формальных параметров. </param >
        static void Main(string[] args)
        {
            /// <summary>
            /// Обьявляю исходные данные 
            /// </summary>
            double a = 2;
            double b = 1;
            double c = 3;
            double x = 2;
            /// <summary>
            /// Вычисляем числитель 
            /// </summary>
            double numeratorPart1 = (3.0 / 4.0) * a * Math.Sqrt(Math.Pow(x, 2) + b * Math.Abs(x));
            double numerator = numeratorPart1 + c;
            /// <summary>
            /// Вычисляем знаменатель
            /// </summary>
            double denominator = Math.Pow(x, 2) + Math.Sin(x);
            /// <summary>
            /// Вычисляем значение y
            /// /// </summary>
            double y = numerator / denominator;
            /// <summary>
            /// Вывод результата на экран функции
            /// /// </summary>
            Console.WriteLine($"Значение функции y = {y}");
            /// <summary>
            /// Округленние
            /// /// </summary>
            Console.WriteLine($"Округленное значение y = {Math.Round(y, 4)}");
        }
    }
}
