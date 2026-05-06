namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* цикл for в котором у пользователя запрашиваются слова, затем
            выводится полная фраза, слова в которой разделены пробелами*/
            string[] a = new string[3];
            Console.Write("Введите вашу фамилию ");
            a[0] = Console.ReadLine();
            Console.Write("Введите ваше имя ");
            a[1] = Console.ReadLine();
            Console.Write("Введите ваше отчество ");
            a[2] = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
