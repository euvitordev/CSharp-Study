using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.Algoritmos
{
    // Exercicio CodeWarns: Basic Mathematical Operations
    // Link: https://www.codewars.com/kata/57356c55867b9b7a60000bd7/train/csharp
    public class basicOp
    {
        public static double Solution(char operation, double value1, double value2)
        {
            if (operation == '+') return value1 + value2;
            if (operation == '-') return value1 - value2;
            if (operation == '*') return value1 * value2;
            if (operation == '/') return value1 / value2;
            return -1;
        }
    }
}
