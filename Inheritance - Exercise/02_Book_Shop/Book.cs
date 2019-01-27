using System;

namespace Library
{
    public class Book
    {
        protected string title;
        protected string author;
        protected decimal price;
        protected string typeOfBook = "Book";
        public Book( string author, string title, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public string Title
        {
            get => title;

            protected set
            {
                if (value.Length < 3||string.IsNullOrEmpty(value)) Error("Title");
                title = value.Trim();
            }
        }

        public string Author
        {
            get => author;
            protected set
            {
                if (char.IsDigit(value.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1][0])
                    || string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) Error("Author");
                author = value;
            }
        }

        public virtual decimal Price
        {
            get => price;
            protected set
            {
                if (value <= 0) Error("Price");
                price = value;
            }
        }


        private void Error(string name)
        {
            throw new ArgumentException($"{name} not valid!");
        }

        public override string ToString()
        {
            return $"Type: {typeOfBook}\nTitle: {this.Title}\nAuthor: {string.Join(" ", this.Author)}\nPrice: {this.Price:F2}";
        }
    }
}