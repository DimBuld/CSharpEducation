namespace Task03
{
    /*Создай класс "Калькулятор" с методами для выполнения основных арифметических
    операций (сложение, вычитание, умножение, деление). Пусть эти методы
    принимают два числа и возвращают результат операции.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.a = 100;
            calculator.b = 50;
            calculator.Itogi();
        }
    }
}
