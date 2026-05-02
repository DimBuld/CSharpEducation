namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // вычисляет длину катетов и гипотенузы

            //a. Известны два катета - найти гипотенузу

            double theCatheter1 = 5;
            double theCatheter2 = 6;
            double result1 = Math.Pow(theCatheter1, 2); //Квадрат катета 1
            double result2 = Math.Pow(theCatheter2, 2);  // Квадрат катета 2
            double result3 = result1 + result2;
            double result4 = Math.Sqrt(result3); //Извлечение квадратного корня
            Console.WriteLine("Гипотенуза равна " + result4);

            //b. Известен один катет и гипотенуза - найти второй катет

            double hypotenuse = 7;
            double catheter1 = 5;
            double result5 = Math.Pow(hypotenuse, 2); //возвести в квадрат гипотенузу
            double result6 = Math.Pow(catheter1, 2); //возвести в квадрат катет
            double result7 = result5 - result6; //неизвестный катет в квадрате
            double catheter2 = Math.Sqrt(result7); //извлечение квадратного корня
            Console.WriteLine("Катет2 равен " + catheter2);

        }
    }
}
