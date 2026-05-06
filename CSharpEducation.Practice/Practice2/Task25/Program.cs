namespace Practice2.Task25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте перечисление (enum) для дней недели. Напишите программу, которая
             считывает ввод пользователя и в зависимости от его ввода (число от 1 до 7)
             будет выводиться на экран консоли соответствующий день недели*/

            Console.WriteLine("Введите значение от 1 до 7, соответсвующее дням недели");
            int a = Convert.ToInt32(Console.ReadLine());
            Day day = (Day)a;  // Преобразует число в Day
            Console.WriteLine(day);
        }
        enum Day
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
    }

}
