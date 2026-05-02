namespace Practice2.Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу для вычисления високосного года.
             год, номер которого кратен 400, — високосный;
            остальные годы, номер которых кратен 100, — невисокосные
            остальные годы, номер которых кратен 4, — високосный;
            все остальные годы — невисокосные.*/

            Console.WriteLine("Введите год");
            int a = Convert.ToInt32(Console.ReadLine());
            if (Year(a))
            {
                Console.WriteLine($"{a} високосный год");
            }
            else 
            {
                Console.WriteLine($"{a} не високосный год");
            }
        }
        public static bool Year(int a) 
        {
        if (a % 400 == 0) 
            {
            return true;
            }
            if (a % 100 == 0) 
            {
            return false;
            }
            if (a % 4 == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
