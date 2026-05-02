namespace Task4
{
    internal class Program
    {
        //считывание из консоли имени и вывод приветственного сообщения.
        static void Main(string[] args)
        {
            Console.Write("Напишите ваше имя ");
            string name = Console.ReadLine();
            Console.Write("Привет ");
            Console.WriteLine (name);
        }
    }
}
