namespace Practice2.Task4a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Нарисуйте прямоугольный треугольник звёздочками. Чтобы высоту
            треугольника можно было задавать программно             
            *
            **
            ***
            ****   */

            Console.Write("Задайте высоту треугольника, положительное целое число: ");
            int height = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
