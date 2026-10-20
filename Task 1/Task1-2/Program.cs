namespace Task1_2
{
    internal class Program
    {            
            Console.Write("Введите число a: ");
            double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
        double sumOfSquares = Math.Pow(a, 2) + Math.Pow(b, 2);
        double squareOfSum = Math.Pow(a + b, 2);  
        Console.WriteLine($"\nСумма квадратов (a² + b²) = {sumOfSquares}");
            Console.WriteLine($"Квадрат суммы (a + b)² = {squareOfSum}");                 
            Console.ReadKey();
        }
}

