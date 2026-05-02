namespace Practice2.Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте и реализуйте метод, который будет принимать число по ссылке (ref) и
            менять его знак на противоположный. Метод должен принимать один аргумент и
            не возвращать ничего*/
            int a = 3;
            ChangeTheSign(ref a);
            Console.Write(a);
        }

        public static void ChangeTheSign(ref int b) 
        {
            b = -b;
        }

    }
}
