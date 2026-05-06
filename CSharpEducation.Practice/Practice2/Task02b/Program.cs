namespace Practice2.Task2b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //переводит километры в сантиметры

            Console.Write("Введите значение в км ");
            string a = Console.ReadLine();
            double.TryParse(a, out double km);
            const int b = 100000;
            double sm = km * b;
            Console.Write("Значение в см: " + sm);

        }
    }
}
