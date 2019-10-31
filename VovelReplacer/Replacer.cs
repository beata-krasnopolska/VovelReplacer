using System;
using System.Collections.Generic;

namespace VovelReplacer
{
    class Replacer
    {
        private List<string> _vovels = new List<string> { "a", "e", "i", "o", "u", "y" };
        private const string _substitute = "#";

        public void Replace (string userString)
        {
            foreach (var vovel in _vovels)
            {
                if (userString.Contains(vovel))
                {
                    userString = userString.Replace(vovel, _substitute);
                }
            }

            Console.WriteLine(userString);
        }
    }
}
