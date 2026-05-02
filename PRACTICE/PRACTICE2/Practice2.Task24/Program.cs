namespace Practice2.Task24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте перечисление (enum) для дней недели. Напишите программу, которая
            выводит на экран дни недели по названиям*/
            Day[] day = (Day[])Enum.GetValues(typeof(Day)); //Преобразовывает enum в массив
            foreach (Day d in day) 
            {
            Console.WriteLine(d);
            }
         }

        enum Day
        {
            Monday, 
            Tuesday, 
            Wednesday, 
            Thursday, 
            Friday, 
            Saturday, 
            Sunday
        }

    }
}