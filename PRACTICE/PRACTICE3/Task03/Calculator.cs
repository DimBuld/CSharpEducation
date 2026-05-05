namespace Task03
{
    internal class Calculator
    {
        public double a;
        public double b;
        public double Slogenie(double a, double b)
        {
            double c = a + b;
            return c;
        }

        public double Vichitanie(double a, double b)
        {
            double c = a - b;
            return c;
        }

        public double Umnogenie(double a, double b)
        {
            double c = a * b;
            return c;
        }
        public double Delenie(double a, double b)
        {
            double c = a / b;
            return c;
        }
        public void Itogi()
        {
            Console.WriteLine($"{a} + {b} = {Slogenie(a, b)}");
            Console.WriteLine($"{a} - {b} = {Vichitanie(a, b)}");
            Console.WriteLine($"{a} * {b} = {Umnogenie(a, b)}");
            Console.WriteLine($"{a} / {b} = {Delenie(a, b)}");
        }

    }
}

