namespace Practice2.Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте и реализуйте метод, который принимает на вход массив и
            инвертирует его. Вызовите его в методе Main. Исходный массив задайте сами.
            Инвертированный массив выведите на экран консоли.*/

            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int[] b = Inven(a);
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i]);
            }
        }

        public static int[] Inven(int[] a)
        {
            Array.Reverse(a);
            return a;
        }
    }
}
