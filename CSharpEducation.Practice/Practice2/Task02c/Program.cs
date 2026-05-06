namespace Practice2.Task2c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //переводит м/с в км/ч

            Console.Write("Введите значение в м/с ");
            string a = Console.ReadLine();
            double.TryParse(a, out double ms);
            const double b = 3.6;
            double kmh = ms * b;
            Console.Write("Значение в км/ч: " + kmh);
        }
    }
}
