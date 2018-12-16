using System;

namespace StringNotPoor
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "The lyrics is not that poor!";
            Console.WriteLine($"{input1} => {NotPoor(input1)}.");
            string input2 = "The lyrics is poor!";
            Console.WriteLine($"{input2} => {NotPoor(input2)}.");
        }

        public static string NotPoor(string input)
        {
            if (input.Contains("not") && input.IndexOf("not") < input.IndexOf("poor"))
            {
                return input.Substring(0, input.IndexOf("not")) + "good" + input.Substring(input.IndexOf("poor") + 4);
            }
            return input;
        }

    }
}





