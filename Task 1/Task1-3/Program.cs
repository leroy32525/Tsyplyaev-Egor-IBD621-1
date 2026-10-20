namespace Task1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите напряжение U (Вольты): ");
                double U = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите сопротивление R (Омы): ");
                double R = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите время t (Секунды): ");
                double t = Convert.ToDouble(Console.ReadLine());
                if (R == 0)
                {
                    Console.WriteLine("Ошибка: Сопротивление не может быть равно нулю!");
                }
                else
                {
                    double q = (U * t) / R;
                    Console.WriteLine($"\nПрошедший заряд q = {q} Кулон");
                    Console.WriteLine($"Округленное значение: {Math.Round(q, 4)} Кл");
                }
            }
}
