namespace Practice2.Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишите игру Угадай число. Программа случайно генерирует число от 1 до
            100, а пользователь пытается угадать это число. При успешной догадке
            выводите поздравление пользователя. Также покажите количество попыток,
            принятых пользователем.
            a. Сделайте ограничение по попыткам. Например, если попыток больше 10,
            то пользователь проиграл*/

            int a;
            Random random = new Random();

            a = random.Next(1, 100);
           
            Console.WriteLine("Угадайте число от 1 до 100");
            int b;  // Ввод числа пользователем
            int d = 0;  //количество попыток пользователя

            do
            {
                b = Convert.ToInt32(Console.ReadLine());
                d++;
                Console.WriteLine($"Вы совершили {d} попыток");
                if (d > 10) 
                {
                    Console.Write("Вы проиграли");
                    break;
                }
                if (a == b)
                {
                    Console.Write("Поздравляю, вы выиграли");
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
