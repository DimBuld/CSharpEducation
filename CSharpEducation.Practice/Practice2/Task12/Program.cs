namespace Practice2.Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу, в которой создаётся массив строк, который заполняется
            пользователем через консоль. Затем этот массив должен быть выведен на
            экран консоли.
            */

            Console.Write("Введите количество элементов массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] a = new string[size];
            for (int i = 0; i < a.Length; i++) 
            {
                Console.Write($"Введите элемент {i + 1}: ");
                a[i] = Console.ReadLine();
            }
            Console.Write("Вы написали: ");
            for (int i = 0;i < a.Length;i++) 
            {
                Console.Write($"{a[i]} ");
            } 


        }
    }
}
