using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.Algoritmos
{
    // Exercicio CodeWarns: Area or Perimeter
    // Link: https://www.codewars.com/kata/5ab6538b379d20ad880000ab/train/csharp
    public class AreaOrPerimeter
    {
        public static int Solution(int l, int w)
        {
            if (l == w) return (l * w); // Retorna a area do quadrado
            if (l != w) return (l * 2) + (w * 2); // Retorna o perímetro do retangulo

            return -1;
        }
    }
}
