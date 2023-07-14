using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";

        // Regex pattern to match HTML tags
        string pattern = "<[^>]+>";

        // Find all matches
        MatchCollection matches = Regex.Matches(input, pattern);

        // Output the matched tags
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
