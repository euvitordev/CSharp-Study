using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.Algoritmos
{
    // Exercicio CodeWarns: Square(n) Sum
    // Link: https://www.codewars.com/kata/515e271a311df0350d00000f/solutions/csharp
    public class SquareSum
    {
        public static int Solution(int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int square = numbers[i] * numbers[i];
                sum += square;
            }
            return sum;
        }
    }
}
