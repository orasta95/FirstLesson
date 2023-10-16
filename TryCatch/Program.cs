namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "";
            /*Square("12");
            Square("ab");*/
            DivideByZero();
            Console.ReadKey();
        }
        static void Square(string text)
        {
            int number;
            if (int.TryParse(text, out number))
            {
                Console.WriteLine($"Number {number}: {number * number}");
            }
            else
            {
                Console.WriteLine("Exception!");
            }
        }

        static void DivideByZero()
        {
            try
            {
                string number = "text";
                int y = int.Parse(number);
                Console.WriteLine($"Result: {y}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception - {ex.Message}");
            }          
        }
    }

    
}












