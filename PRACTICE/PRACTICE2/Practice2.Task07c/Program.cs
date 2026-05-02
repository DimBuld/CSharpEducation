using System.Globalization;

namespace Practice2.Task7c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, которая делает заглавную букву в слове: привет->Привет

            string a = "привет";
            char[] b = a.ToCharArray();  //преобразование в массив символов
            b[0] = char.ToUpper(b[0]);                       
            Console.WriteLine(b);
        }
    }
}
