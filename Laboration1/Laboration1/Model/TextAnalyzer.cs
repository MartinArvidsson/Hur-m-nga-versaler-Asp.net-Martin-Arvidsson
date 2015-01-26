using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboration1.Model
{
    public static class TextAnalyzer
    {
        public static int NumberOfCapitals(string input)
        {
            int CapitalLetters = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i])) CapitalLetters++;
            }
            return CapitalLetters;
        }
    }
}