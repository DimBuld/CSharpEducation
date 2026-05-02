namespace Practice2.Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте и реализуйте метод, который будет принимать массив на вход убирать
             из него отрицательные числа и возвращать новый изменённый массив. Через
             out параметр возвращать количество удалённых символов.*/

            int[] a = new int[] { -3, -2, -1, 0, 1, 2, 3 };
            int c;  //количество удаленных элементов
            int[] aNew = abc(a,out c);  //новый массив без отрицательных чисел
            foreach (int i in aNew) 
            {
            Console.WriteLine(i);
            }
            Console.Write($"Количество удаленных символов {c}");
        }
        public static int[] abc(int[] a, out int c)
        {
            int[] b = Array.FindAll(a, (val) => val >= 0);  //удаление отрицательных чисел
            c = a.Length - b.Length; // количество удаленных символов
            return b;
        }
    }
}
