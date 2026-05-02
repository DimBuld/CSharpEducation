namespace Practice2.Task2d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //переводит градусы C в градусы F

            Console.Write("Введите значение в градусах С ");
            string a = Console.ReadLine();
            double.TryParse(a, out double c);
            const double b = 33.8;
            double F = c * b;
            Console.Write("Значение в F: " + F);
        }
    }
}
