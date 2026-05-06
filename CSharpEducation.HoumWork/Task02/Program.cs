namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Игра «Крестики-Нолики» (TicTacToe).
            Игрок против игрока.
            Отрисовка поля 3*3 в консоли.
            Считывание хода игрока.
            Проверка корректности хода.
            Проверка победной комбинации хода.
            Проверка на ничью.
            Дополнительно:
            Подсветка ходов.*/

            char[][] a = new char[3][];
            a[0] = new char[] { '1', '2', '3' };
            a[1] = new char[] { '4', '5', '6' };
            a[2] = new char[] { '7', '8', '9' };
            Console.WriteLine();
            Console.WriteLine("-------------------");
            for (int i = 0; i < a.Length; i++)
            {

                Console.Write("|");
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write("  " + a[i][j]);
                    Console.Write("  |");
                }
                Console.WriteLine();
                Console.WriteLine("-------------------");
            }

            bool c;  // корректность введенного символа
            bool d;  //корректность хода
            bool e = false;  // выигрыш
            bool f = false;  //ничья

            while (true)
            {
                do
                {
                    if (e == true)
                    {
                        break;
                    }
                    if (f == true)
                    {

                        a[0] = ['1', '2', '3'];
                        a[1] = ['4', '5', '6'];
                        a[2] = ['7', '8', '9'];
                        Console.WriteLine();
                        Console.WriteLine("-------------------");
                        for (int i = 0; i < a.Length; i++)
                        {

                            Console.Write("|");
                            for (int j = 0; j < a[i].Length; j++)
                            {
                                Console.Write("  " + a[i][j]);
                                Console.Write("  |");
                            }
                            Console.WriteLine();
                            Console.WriteLine("-------------------");
                        }


                    }
                    Console.WriteLine();
                    Console.Write("Сделайте ход 'X': ");
                    char b = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    c = Proverka(b);
                    d = Proverka2(a, ref b);
                    if (c == true && d == true)
                    {
                        Console.WriteLine("-------------------");
                        for (int i = 0; i < a.Length; i++)
                        {
                            Console.Write("|");
                            for (int j = 0; j < a[i].Length; j++)
                            {
                                if (a[i][j] == b)
                                {
                                    a[i][j] = 'X';
                                }
                                if (a[i][j] == 'X')
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;

                                }
                                if (a[i][j] == '0')
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;

                                }
                                Console.Write("  " + a[i][j]);
                                Console.ResetColor();
                                Console.Write("  |");

                            }

                            Console.WriteLine();
                            Console.WriteLine("-------------------");
                        }

                        if (a[0][0] == 'X' && a[0][1] == 'X' && a[0][2] == 'X' || a[1][0] == 'X' && a[1][1] == 'X' && a[1][2] == 'X' || a[2][0] == 'X' && a[2][1] == 'X' && a[2][2] == 'X' || a[0][0] == 'X' && a[1][0] == 'X' && a[2][0] == 'X' || a[0][1] == 'X' && a[1][1] == 'X' && a[2][1] == 'X' || a[0][2] == 'X' && a[1][2] == 'X' && a[2][2] == 'X' || a[0][0] == 'X' && a[1][1] == 'X' && a[2][2] == 'X' || a[0][2] == 'X' && a[1][1] == 'X' && a[2][0] == 'X')
                        {
                            e = true;
                            Console.Write("ПОБЕДААА 'X'");
                        }
                        f = Proverka3(a);
                        if (f == true && e == false)
                        {
                            Console.WriteLine("Ничья");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка введенного значения, повторите ход");
                    }

                }
                while (c == false || d == false);
                do
                {
                    if (e == true)
                    {
                        break;
                    }
                    if (f == true)
                    {
                        a[0] = ['1', '2', '3'];
                        a[1] = ['4', '5', '6'];
                        a[2] = ['7', '8', '9'];

                        Console.WriteLine();
                        Console.WriteLine("-------------------");
                        for (int i = 0; i < a.Length; i++)
                        {

                            Console.Write("|");
                            for (int j = 0; j < a[i].Length; j++)
                            {
                                Console.Write("  " + a[i][j]);
                                Console.Write("  |");
                            }
                            Console.WriteLine();
                            Console.WriteLine("-------------------");
                        }

                    }

                    Console.WriteLine();
                    Console.Write("Сделайте ход '0': ");
                    char b = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    c = Proverka(b);
                    d = Proverka2(a, ref b);
                    if (c == true && d == true)
                    {
                        Console.WriteLine("-------------------");
                        for (int i = 0; i < a.Length; i++)
                        {
                            Console.Write("|");
                            for (int j = 0; j < a[i].Length; j++)
                            {
                                if (a[i][j] == b)
                                {
                                    a[i][j] = '0';
                                }
                                if (a[i][j] == '0')
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;

                                }
                                if (a[i][j] == 'X')
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;

                                }
                                Console.Write("  " + a[i][j]);
                                Console.ResetColor();
                                Console.Write("  |");

                            }

                            Console.WriteLine();
                            Console.WriteLine("-------------------");
                        }
                        if (a[0][0] == '0' && a[0][1] == '0' && a[0][2] == '0' || a[1][0] == '0' && a[1][1] == '0' && a[1][2] == '0' || a[2][0] == '0' && a[2][1] == '0' && a[2][2] == '0' || a[0][0] == '0' && a[1][0] == '0' && a[2][0] == '0' || a[0][1] == '0' && a[1][1] == '0' && a[2][1] == '0' || a[0][2] == '0' && a[1][2] == '0' && a[2][2] == '0' || a[0][0] == '0' && a[1][1] == '0' && a[2][2] == '0' || a[0][2] == '0' && a[1][1] == '0' && a[2][0] == '0')
                        {
                            e = true;
                            Console.Write("ПОБЕДААА '0'");
                        }
                        f = Proverka3(a);
                        if (f == true && e == false)
                        {
                            Console.WriteLine("Ничья");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка введенного значения, повторите ход");
                    }

                }
                while (c == false || d == false);
            }

        }
        public static bool Proverka(char b)
        {
            bool a;
            if (b == '1' || b == '2' || b == '3' || b == '4' || b == '5' || b == '6' || b == '7' || b == '8' || b == '9')
            {
                a = true;
            }
            else
            {
                a = false;
            }
            return a;
        }
        public static bool Proverka2(char[][] chars, ref char b)
        {
            bool c = false;
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < chars[i].Length; j++)
                {
                    if (chars[i][j] == b)
                    {
                        c = true;
                        break;
                    }
                }
            }
            return c;
        }
        public static bool Proverka3(char[][] chars)
        {
            bool c = false;
            for (int i = 0; i < chars.Length; i++)
            {
                for (int j = 0; j < chars[i].Length; j++)
                {
                    if (chars[0][0] != '1' && chars[0][1] != '2' && chars[0][2] != '3' && chars[1][0] != '4' && chars[1][1] != '5' && chars[1][2] != '6' && chars[2][0] != '7' && chars[2][1] != '8' && chars[2][2] != '9')
                    {
                        c = true;
                    }
                }
            }
            return c;
        }
    }
}
