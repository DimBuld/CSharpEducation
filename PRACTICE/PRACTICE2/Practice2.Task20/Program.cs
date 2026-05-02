namespace Practice2.Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте двумерный массив целых чисел произвольной длины и заполните
            случайными числами от 1 до 100. Выведите на экран разницу максимального и
            минимального значений в каждой строке массива*/

            int[,] a = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(1, 100);
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
            int[] b = new int[a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[j] = a[i, j];
                }

                int min = b.Min();
                int max = b.Max();
                int c = max  - min;
                Console.WriteLine($"Разница максимального и минимального значения строки {i + 1} равна {c}");
            }


        }
    }
}
