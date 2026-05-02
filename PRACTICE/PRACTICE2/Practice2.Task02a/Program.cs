namespace Practice2.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //переводит метры в километры

            Console.Write("Введите расстояние в метрах: ");


            string a = Console.ReadLine(); //  метры
            double.TryParse(a, out double m);  //строка в число
            const int b = 1000;
            double km = m / b; // перевод в км
            Console.Write("Расстояние в км = " + km);






        }
    }
}
