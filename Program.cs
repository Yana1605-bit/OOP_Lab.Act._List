using System.Security.Cryptography;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> names = new List<string>();
        string input;

        while (true)
        {
            Console.Write("Enter a name or 'done' to finish: ");
            input = Console.ReadLine();

            if (input.ToLower() == "done")
                break;

            if (!string.IsNullOrWhiteSpace(input))
            {
                names.Add(input.ToUpper());
            }
        }

        int count_a = 0;
        Console.WriteLine("\nPresent student names (Uppercase)");
        foreach (string name in names)
        {
            foreach (char n in name)
            {
                if (n == 'A')
                    count_a++;
            }
            Console.Write($" {name} \n");
        }

        Console.WriteLine($"\nTotal number of 'A': {count_a}");
    }
}