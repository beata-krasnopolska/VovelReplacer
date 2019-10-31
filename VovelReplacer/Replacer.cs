using System;
using System.Collections.Generic;

namespace VovelReplacer
{
    class Replacer
    {
        private List<string> vovels = new List<string> { "a", "e", "i", "o", "u", "y" };

        public void Replace (string userString)
        { 
            char substitute = '#';

            for (int i =0; i<userString.Length; i++)
            {
                for(int j =0; j<vovels.Count; j++)
                if (userString.Contains(vovels[j]))
                {
                     userString.Replace(userString[i], substitute);                        
                }
            }
            Console.WriteLine(userString);
        }
    }
}
