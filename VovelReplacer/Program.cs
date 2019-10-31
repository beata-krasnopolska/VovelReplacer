using System;

namespace VovelReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program replaces all the vowels in a string with a specified character.");
            
            Console.WriteLine("Enter a string:");
            string userString = Console.ReadLine();

            var vovelReplacer = new Replacer();
            vovelReplacer.Replace(userString);

            Console.ReadKey();
        }
    }
}
