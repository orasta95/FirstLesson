namespace Classes
{
    public class Book
    {
        public Book(string name, int countOfPages, string author)
        {
            this.name = name;
            this.countOfPages = countOfPages;
            this.author = author;
        }

        public Book(string name)
        {
            Console.WriteLine("This books name is {0}", name);
        }

        string name = "Undefined";
        int countOfPages = 0;
        string author = "Undefined";

        public void Print()
        {
            Console.WriteLine("Name of book is {0}, count of pages are {1}, Author is {2}.", name, countOfPages, author);
        }
    }
}
