namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //вычисляет формулу площади круга и выводит результат на экран консоли
            
            double radius = 6.5;
            const double p = 3.14;
            double result = Math.Pow(radius, 2); //Возведение в квадрат
            double theAreaOfTheCircle = p * result;
            Console.WriteLine("Площадь круга " + theAreaOfTheCircle);
        }
    }
}
