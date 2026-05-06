namespace Practice2.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу, в которой создаётся массив и выводится на экран
             консоли. Размер массива передавайте в качестве первого аргумента командной
             строки. Число, которым будет заполняться массив передайте через второй
             аргумент командной строки.*/

            int[] a = new int[Convert.ToInt32(args[0])];
            for (int i = 0; i < a.Length; i++) 
            {
                a[i] = Convert.ToInt16(args[1]);
                Console.WriteLine(a[i]);
            }
        }
    }
}
