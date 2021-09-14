using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            var hangman = new Hangman();
            hangman.Run();
            
            //StandardMessages.WelcomeMessage();

            //GamePlay.PlayGame();

            //GamePlay.GuessLetter();
        }
    }
}
