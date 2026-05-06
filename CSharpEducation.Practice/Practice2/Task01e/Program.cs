namespace Practice2.Task1e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*цикл while, в котором у пользователя запрашиваются слова, затем
            выводится полная фраза, слова в которой разделены пробелами.*/

            string[] a = new string[3];
            Console.Write("Введите вашу фамилию ");
            a[0] = Console.ReadLine();
            Console.Write("Введите вашу имя ");
            a[1] = Console.ReadLine();
            Console.Write("Введите вашу отчество ");
            a[2] = Console.ReadLine();
            int i = 0;
            while (i < a.Length)
            {
                Console.Write(a[i++] + " ");
            }

        }
    }
}
