namespace Task1_2
{
    internal class Program
    {
  {
            // 1. Ввод данных
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());

        // 2. Вычисления
        // Сумма квадратов: a^2 + b^2
        double sumOfSquares = Math.Pow(a, 2) + Math.Pow(b, 2);

        // Квадрат суммы: (a + b)^2
        double squareOfSum = Math.Pow(a + b, 2);

        // 3. Вывод результатов
        Console.WriteLine($"\nСумма квадратов (a² + b²) = {sumOfSquares}");
            Console.WriteLine($"Квадрат суммы (a + b)² = {squareOfSum}");
            
            // Ожидание нажатия клавиши, чтобы консоль не закрылась сразу
            Console.ReadKey();
        }
}
              
           
      


