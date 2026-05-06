namespace Practice2.Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишите метод, который создаёт массив целых чисел и возвращает его.
            Размер массива нужно передавать в качестве аргумента. Вдобавок напишите
            метод, который выводит переданный массив на экран консоли*/

            int[] a = Integers(5);
            Consol(a);
;
            
        }
        public static int [] Integers(int size) 
        {
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = i + 1;
            }
            return a;
        }
        public static void Consol(int[] a) 
        {
            for (int i = 0;i < a.Length;i++) 
            {
            Console.WriteLine(a[i]);
            }
        }

    }
}
