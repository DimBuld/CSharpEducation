namespace Practice2.Task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишите игру Угадай число. Программа случайно генерирует число от 1 до
            100, а пользователь пытается угадать это число. При успешной догадке
            выводите поздравление пользователя.*/

            int a;
            Random random = new Random();
            a = random.Next(1, 100);
            Console.WriteLine("Угадайте число от 1 до 100");
            int b;
            do
            {
                b = Convert.ToInt32(Console.ReadLine());
                if (b == a)
                {
                    Console.Write("Поздравляю, вы угадали");
                }
                else
                {
                    Console.WriteLine("Повторите попытку");
                }
            }
            while (a != b);

        }
    }
}
