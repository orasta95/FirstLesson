namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book = new Book("Harry Poter", 600, "Joan");
            Book book2 = new Book("Good to Great");
            book.Print();

            
            Console.ReadKey();
        }
    }
    class Person
    {
        public string name = "Tom";
        public int age = 43;

        public void NamePerson()
        {
            Console.WriteLine("My name is {0}, my age is {1}", name, age);
        }

    }
}
