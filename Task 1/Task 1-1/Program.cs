namespace Task_1_1
{
   {
    class Program
        //вфвффвф
    {
        static void Main(string[] args)
        {
          //вфв
            double a = 2;
            double b = 1;
            double c = 3;
            double x = 2;
            double numeratorPart1 = (3.0 / 4.0) * a * Math.Sqrt(Math.Pow(x, 2) + b * Math.Abs(x));
            double numerator = numeratorPart1 + c;
            double denominator = Math.Pow(x, 2) + Math.Sin(x);
            double y = numerator / denominator;
            Console.WriteLine($"Значение функции y = {y}");  
            Console.WriteLine($"Округленное значение y = {Math.Round(y, 4)}");
        }
    }
}

