using System.Globalization;

namespace Practice2.Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте и реализуйте метод, который принимает на вход размер массива n и
            возвращает пустой массив указанного размера. Вызовите метод в методе Main
            и заполните его полученный массив. Содержимое массива выведите на экран.
            */

            int[] a = Numbers(5);
            for (int i = 0; i < a.Length; i++) 
            {
                a[i] = i + 1;
                Console.WriteLine(a[i]);
            }
        }

        public static int[] Numbers(int n) 
        {
            int[] b = new int[n]; 
            return b;
        }
    }
}
