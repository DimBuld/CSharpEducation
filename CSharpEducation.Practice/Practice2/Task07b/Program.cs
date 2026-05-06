namespace Practice2.Task7b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая переводит строку в нижний регистр: F -> f

            string a = "ПРИВЕТ МИР";
            string b = a.ToLower();  // перевод в нижний регистр
            Console.Write($"Фраза в нижнем регистре: {b}");
        }
    }
}
