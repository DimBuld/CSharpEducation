namespace Task02
{
    internal class Student
    {
        public string name;
        public int age;
        private double sredniyBal;
        public double SredniyBal
        {
            get
            {
                return sredniyBal;
            }
            set
            {
                Console.WriteLine($"Имя студента {name}");
                Console.WriteLine($"Возраст студента {age}");
                if (value >= 0 && value <= 5)
                {
                    sredniyBal = value;
                    Console.WriteLine($"Средний бал студента {sredniyBal}");
                }
                else
                {
                    Console.WriteLine("Ошибка, средний балл должен быть в диапозоне от 0 до 5");
               
                }
            }
        }

        //public void Cons()
        //{
        //    Console.WriteLine($"Имя студента {name}");
        //    Console.WriteLine($"Возраст студента {age}");
        //    Console.WriteLine($"Средний бал студента {sredniyBal}");
        //}


    }
}
