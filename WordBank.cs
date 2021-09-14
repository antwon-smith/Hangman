using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    
    public class WordBank
    {
        private List<string> words;

        public WordBank()
        {
            words = new List<string>();
            words.Add("Rainbow");
            words.Add("Happy");
            words.Add("Polymorphism");
            words.Add("Abstraction");
            words.Add("Encapsulation");
        }

        public string GetWord()
        {
            var random = new Random();
            var index = random.Next(words.Count);

            return words[index];
        }
    }
}
