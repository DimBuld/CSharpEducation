namespace Practice2.Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу для сравнения двух целых чисел. Ввод осуществляйте через консоль.

            Console.Write("Введите целое число 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Число {num1} меньше числа {num2}");
            }
            else 
            {
                Console.WriteLine($"Число {num1} равно числу {num2}");
            }
        }
    }
}
