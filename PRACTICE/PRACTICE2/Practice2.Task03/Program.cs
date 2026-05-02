namespace Practice2.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //программа для вычисления выражения (а + b — f / а) + f * a * a — (a + b).
            //Все переменные задаются пользователем.

            double a;
            do
            {
                Console.Write("Введите значение a ");
                a = Convert.ToDouble(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Ошибка деления на ноль ");
                }

            }
            while (a == 0);

            Console.Write("Введите значение b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение f ");
            double f = Convert.ToDouble(Console.ReadLine());
            double result = (a + b - f / a) +f * a * a - (a + b);
            Console.Write("Результат вычисления: " + result);


        }
    }
}
