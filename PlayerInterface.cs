using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class PlayerInterface
    {
        public void Tell(string tell)
        {
            Console.WriteLine(tell);
        }

        
        public char AskForChar(string ask)
        {
            Console.WriteLine(ask);
            var result = Console.ReadLine();
            char character;

            if (!Char.TryParse(result, out character))
            {
                AskForChar(ask);
            }

            return character;
        }
    }
}
