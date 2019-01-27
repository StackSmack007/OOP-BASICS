namespace Library
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string n, string a, decimal p) : base(n, a, p)
        {
            Price *= 1.3m;
            typeOfBook = "GoldenEditionBook";
        }
    }
}