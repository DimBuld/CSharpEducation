namespace Practice2.Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу, в которой создаётся массив и выводится на экран консоли. 
             * Размер массива передавайте в качестве первого аргумента командной строки*/

            int[] a = new int[Convert.ToInt16(args[0])];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i + 1;
                Console.WriteLine(a[i]);
            }
        }

    }
}
