using System;
using System.Text.RegularExpressions;
using System.IO;

namespace CST_150_Activity12
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            if (args.Length == 0)
            {
                text = File.ReadAllText(@"../../testFile.txt");
            }else
            {
                text = File.ReadAllText(args[0]);
            }
            Console.WriteLine(Directory.GetCurrentDirectory());
            //string text = "This is a test provided by me. \n test " +
            //    "this is another test";
            Int64 matchCount = Regex.Matches(text, "([te])(?![a-z])", RegexOptions.Multiline | RegexOptions.IgnoreCase).Count;
            Console.WriteLine("There are "+matchCount+" words that end in t or e");
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
