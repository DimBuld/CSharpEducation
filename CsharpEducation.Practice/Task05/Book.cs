namespace Task05
{
    internal class Book
    {
        public string nazvznie;
        public string avtor;
        public int god;

        public Book()
        {
            nazvznie = "Азбука";
            avtor = "Я";
            god = 1983;
        }

        public Book(string naz, string av, int g)
        {
            nazvznie = naz;
            avtor = av;
            god = g;
        }

        public Book(string naz)

        {
            this.nazvznie = naz;
        }
        public Book(string naz, string av)
        {
            this.nazvznie = naz;
            this.avtor = av;
        }

    }

}
