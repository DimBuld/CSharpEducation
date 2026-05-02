namespace Practice2.Task4c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*возможность задавать символ для отрисовки программно. Т.е.
            вместо звёздочки может быть любой символ*/

            Console.Write("Задайте высоту треугольника, положительное целое число: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Укажите символ для отрисовки треугольника: ");
            char a = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
        }
    }
}
