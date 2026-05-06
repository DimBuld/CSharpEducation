namespace Practice2.Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте и реализуйте метод, который будет принимать два числа и менять их
             значения местами. Вызовите метод в Main. */

            int a = 5;
            int b = 10;
            SwapPlaces(ref a,ref b);
            Console.Write($"{a} {b}");
        }
        public static void SwapPlaces(ref int a,ref int b) 
        {
            (a, b) = (b, a);
        }
    }
}
