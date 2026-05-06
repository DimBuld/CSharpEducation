namespace Practice2.Task7a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу, которая переводит строку  в верхний регистр: f->F*/

            string a = "привет мир";
            string b = a.ToUpper();  // перевод в верхний регистр
            Console.Write($"Фраза в верхнем регистре: {b}");
        }
    }
}
