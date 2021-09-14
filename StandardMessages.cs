using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Hangman!\n \nThe objective of the game is to find out the mystery word by guessing a single letter at a time.\n \nEach incorrect guess will result in a 'body part'' being drawn on your hangman.\n \nIf your hangman is fully drawn before you correctly guess the phrase, you lose.  If you guess the phrase correctly, you win!\n ");
            Console.WriteLine("Press any key when you are ready to continue:");
            Console.ReadLine();
        }
    }
}
