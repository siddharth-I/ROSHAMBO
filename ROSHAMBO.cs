using System;
using System.Collections.Generic;
using System.Text;

namespace ROSHAMBO
{
    public class ROSHAMBO
    {
        public string StartGame(string inputOne, string inputTwo)
        {
            Console.WriteLine("What is your first play?");
            inputOne = Console.ReadLine();
            Console.WriteLine("What is your second play?");
            inputTwo = Console.ReadLine();
            if (inputOne == "Rock" && inputTwo == "Paper") || (inputOne == "Paper" && inputTwo == "Rock");
            {
                Console.WriteLine("Paper covers Rock");
            }
            else if (inputOne == "Scissors" && )
        }
    }
}
