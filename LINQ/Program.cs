using System.Linq;



namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bookList = new List<string>() { "black boy", "blueprint for black power", "the isis papers",
                "afrikan holistic health"};

            var bookNames = bookList.OrderBy(name => name.Length).ToList(); 

            foreach (var book in bookNames)
            {
                Console.WriteLine(book);
            }

        }

    }
}
