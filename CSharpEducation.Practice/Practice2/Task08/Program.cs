namespace Practice2.Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Составить алгоритм увеличения всех трех, введенных с клавиатуры,
            переменных на 5, если среди них есть хотя бы две равные.В противном случае
            выдать ответ «равных нет»*/

            Console.Write("Введите значение(a): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение(b): ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение(c): ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == b || a == c || b == c)
            {
                a = a + 5;
                b = b + 5;
                c = c + 5;
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"b = {b}");
                Console.WriteLine($"c = {c}");
            }
            else 
            {
                Console.Write("Равных нет");
            }
        }
    }
}
