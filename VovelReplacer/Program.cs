using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
