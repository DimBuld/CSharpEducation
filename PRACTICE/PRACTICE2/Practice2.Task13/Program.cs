namespace Practice2.Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишите метод, который создаёт двумерный массив (не зубчатый). Размеры
            массива передавайте через аргументы метода. Также напишите отдельный
            метод для вывода двумерного массива в виде матрицы на экран консоли.
            Массив заполните случайными числами.
            */
            int[,] a = Numbers(4,5);
            Consol(a);

        }
        public static int[,] Numbers(int size, int size1)

        {
            int[,] matrix = new int[size, size1];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size1; j++)
                {
                    matrix[i, j] = random.Next(10);
                }
            }
            return matrix;
        }
        public static void Consol(int[,] a)

        {
            for (int i = 0; i < a.GetLength(0); i++) 
            {
                for (int j = 0; j < a.GetLength(1); j++) 
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
