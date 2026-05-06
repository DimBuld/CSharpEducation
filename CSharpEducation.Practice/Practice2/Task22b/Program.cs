namespace Practice2.Task22b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишите игру Угадай число. Программа случайно генерирует число от 1 до
             100, а пользователь пытается угадать это число. При успешной догадке
             выводите поздравление пользователя. Также покажите количество попыток,
             принятых пользователем.
             Сделайте подсказки для пользователя. Если предположенное число
             больше загаданного, то писать в консоль об этом. Аналогично и для
             меньшего числа.*/

            int a;
            Random random = new Random();
            a = random.Next(1, 100);
            Console.WriteLine("Угадайте число от 1 до 100");
            int b; // Ввод пользователя
            int c = 0;
            do
            {
                b = Convert.ToInt32(Console.ReadLine());
                c++;
                if (b > a)
                {
                    Console.WriteLine("Ваше число больше заданного");
                }
                if (b < a)
                {
                    Console.WriteLine("Ваше число меньше заданного");
                }
                Console.WriteLine($"Вы совершили {c} попыток");
                if (a == b)
                {
                    Console.WriteLine("Поздравляю, вы выиграли");
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
