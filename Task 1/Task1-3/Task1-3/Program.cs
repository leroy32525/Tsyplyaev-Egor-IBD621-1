namespace Task1_3
{
    internal class Program
    {
        class Program
        {
            /// <param name="args"> Список формальных параметров. </param >
            static void Main(string[] args)
            {
                /// <summary>
                /// Ввод данных вручную пользователем
                /// </summary>
                Console.Write("Введите напряжение U (Вольты): ");
                double U = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите сопротивление R (Омы): ");
                double R = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите время t (Секунды): ");
                double t = Convert.ToDouble(Console.ReadLine());

                /// <summary>
                /// Проверка, чтобы число не равнялось 0
                /// </summary>
                /// Конструкция условия
                if (R == 0)
                {
                    Console.WriteLine("Ошибка: Сопротивление не может быть равно нулю!");
                }
                else
                {
                    /// <summary>
                    /// Вычисление заряда по формуле q = (U * t) / R
                    /// </summary>
                    double q = (U * t) / R;

                    /// <summary>
                    /// Вывод результата 
                    /// </summary>
                    Console.WriteLine($"\nПрошедший заряд q = {q} Кулон");

                    /// <summary>
                    /// Округления числа
                    /// </summary>
                    Console.WriteLine($"Округленное значение: {Math.Round(q, 4)} Кл");
                }
            }
        }
    }
}

