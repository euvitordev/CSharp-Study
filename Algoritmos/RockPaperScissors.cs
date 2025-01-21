﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Study.Algoritmos
{
    public class RockPaperScissors
    {
        public static string Solution(string p1, string p2)
        {
            string scissors = "scissors";
            string paper = "paper";
            string rock = "rock";

            if (p1 == p2)
                return "Draw!";

            if (p1 == scissors && p2 == paper || p1 == rock && p2 == scissors || p1 == paper && p2 == rock)
                return "Player 1 won!";
            else return "Player 2 won!";

            return "Error...";
        }
    }
}
