using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Defining a regex pattern to match MMDDYYYY format
        string pattern = @"\b(0[1-9]|1[0-2])(0[1-9]|[12][0-9]|3[01])(19|20)\d{2}\b";

        // Finding matches
        Match match = Regex.Match(input, pattern);

        if (match.Success)
        {
            Console.WriteLine("Valid date: " + match.Value);
        }
        else
        {
            Console.WriteLine("No valid date found");
        }
    }
}