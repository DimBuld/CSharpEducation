namespace Task01
{/*Создай класс "Студент" с полями "Имя" и "Возраст". Напиши метод, который будет
    выводить информацию о студенте в консоль*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.name = "Дмитрий";
            student.age = 42;
            student.Consol();
        }
    }
}
