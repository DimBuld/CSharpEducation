namespace Practice2.Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте одномерный массив целых чисел произвольной длины и заполните
            случайными числами от 1 до 100. Выведите на экран разницу максимального и
            минимального значений в нём. */

            int[] a = new int[10];
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(1, 100);
                Console.WriteLine($"Элемент массива {i}: {a[i]}");
            }
            int min = a.Min();
            int max = a.Max();
            int b = max - min;
            Console.WriteLine($"min {min}");
            Console.WriteLine($"max {max}");
            Console.WriteLine($"Разница между максимальным и минимальным значением массива: {b}");
        }
    }
}
