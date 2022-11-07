using System.Linq;



namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> bookNames = new List<string>
            { "black boy", "blueprint for black power", "the isis papers",
                "afrikan holistic health"};

            IEnumerable<string> longBookNames =
                bookNames.Where(name => name.Contains("a"));

            foreach (var o in bookNames)
            {
                Console.WriteLine(o);
            }

        }

    }
}
