namespace Task04
{
    internal class Book
    {
        public string nazvanie;
        public string avtor;
        public Book(string naz, string av)
        {
            nazvanie = naz;
            avtor = av;
        }
        public Book()
        {
            nazvanie = "книга";
            avtor = "Я";
        }
        
    }
}
