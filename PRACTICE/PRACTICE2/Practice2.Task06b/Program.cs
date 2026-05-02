namespace Practice2.Task6b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения
             * заданного символа в строку.
              строка и символ указываются пользователем в консоли*/

            Console.Write("Введите фразу: ");
            string a = Console.ReadLine(); 
            Console.Write("Введите искомый символ: ");
            char b = Convert.ToChar(Console.ReadLine()); //искомый символ

            int i = 0;
            foreach (char c in a) { i++; }

            int j = 0;
            foreach (char c in a)
            {
                if (c == b)
                    j++;
            }
            double d = j * 100 / i; // вычисление процента вхождения
            Console.WriteLine($"Процент вхождения символа 'и' в строку: {d}");
        }
    }
}
