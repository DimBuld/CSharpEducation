namespace Task5
{
    internal class Program
    {
        /*считывание из консоли фразы и сохранение её, затем считывание второй фразы и вывод
         * на экран консоли обеих этих фраз, объединённых в одно предложение.*/
        static void Main(string[] args)
        {
            Console.Write("Напишите ваше имя ");
            string name = Console.ReadLine();
            Console.Write("Напишите вашу фамилию ");
            string surname = Console.ReadLine();
            Console.WriteLine(name + " " + surname);
        }
    }
}
