using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            // strings
            string userName = "javad";
            string willBeTrimmedText = "    sample text           ";

            Console.WriteLine("Hello World!");
            Console.WriteLine($"my name is {userName}");
            Console.WriteLine(userName.Length);
            Console.WriteLine(willBeTrimmedText.Trim());
            Console.WriteLine(willBeTrimmedText.TrimStart());
            Console.WriteLine(willBeTrimmedText.TrimEnd());
            Console.WriteLine(willBeTrimmedText.ToUpper());
            Console.WriteLine(willBeTrimmedText.ToLower());
            Console.WriteLine(willBeTrimmedText.Replace("s", "z"));
            Console.WriteLine(userName.StartsWith("j"));
            Console.WriteLine(userName.EndsWith("j"));
            Console.WriteLine(userName.Contains("v"));

        }
    }
}
