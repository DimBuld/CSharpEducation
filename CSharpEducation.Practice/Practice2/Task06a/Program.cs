namespace Practice2.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Введите с клавиатуры строку произвольной длины и подсчитайте процент
            вхождения заданного символа в строку, строка и символ указываются программно*/

            string a = "Булдаков Дмитрий Владимирович";
            char b = 'и'; //искомый символ

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
