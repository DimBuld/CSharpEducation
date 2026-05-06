namespace Task05
{
    internal class Program
    {
        /*Создай класс "Книга" с полями "Название" и "Автор". Реализуй два конструктора:
        один с параметрами для инициализации полей, другой без параметров, который
        будет устанавливать значения по умолчанию. Расширь класс "Книга" из
        предыдущего задания, добавив поле "Год издания". Реализуй цепочку
        конструкторов так, чтобы можно было создавать объекты класса "Книга" с
        указанием только названия, названия и автора, или всех трех полей.
        */
        static void Main(string[] args)
        {
            Book kniga1 = new Book();
            Book kniga2 = new Book("Математика");
            Book kniga3 = new Book("История", "Иванов");
            Book kniga4 = new Book("Физика", "Сидоров",2000 );
            Console.WriteLine(kniga1.nazvznie + " " + kniga1.avtor + " " + kniga1.god);
            Console.WriteLine(kniga2.nazvznie + " " + kniga2.avtor + " " + kniga2.god);
            Console.WriteLine(kniga3.nazvznie + " " + kniga3.avtor + " " + kniga3.god);
            Console.WriteLine(kniga4.nazvznie + " " + kniga4.avtor + " " + kniga4.god);
        }
    }
}
