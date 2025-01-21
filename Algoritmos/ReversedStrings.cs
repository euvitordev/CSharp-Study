using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.Algoritmos
{
    public class ReversedStrings
    {
        // Exercicio CodeWarns: Reversed Strings
        // Link: https://www.codewars.com/kata/5168bb5dfe9a00b126000018/solutions/csharp

        // Solution
        public static string Solution(string value)
        {
            string solution = "";

            for (int i = value.Length - 1; i >= 0; i--)
                solution += value[i];

            return solution;
        }
    }
}
