using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    internal class RPSGame
    {
        List<string> compChoices = new List<string>() { "Камень", "Ножницы", "Бумага" };
        Random rand = new Random();
        public string compChoice { get; private set; }

        public RPSGame() { }
        public int Run(string userChoice) {
            compChoice = compChoices[rand.Next(0,compChoices.Count)];
            if (userChoice == compChoice) { return 0; }
            if (userChoice == "Камень") {
                if (compChoice == "Ножницы") {
                    return 1;
                }
                if (compChoice == "Бумага")
                {
                    return -1;
                }
            }
            if (userChoice == "Ножницы")
            {
                if (compChoice == "Камень")
                {
                    return -1;
                }
                if (compChoice == "Бумага")
                {
                    return 1;
                }
            }
            if (userChoice == "Бумага")
            {
                if (compChoice == "Камень")
                {
                    return 1;
                }
                if (compChoice == "Ножницы")
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
