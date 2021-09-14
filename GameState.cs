using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class GameState
    {
        private string answer;

        private List<char> guesses = new List<char>();

        private int lives;

        public GameState(int lives, string answer)
        {
            this.answer = answer;
            this.lives = lives;
        }

        public int GetLives()
        {
            return lives;
        }

        public void LoseLife()
        {
            lives--;
        }

        public bool CheckIfNoLives()
        {
            return lives < 1;
        }

        public int GetAnswerLength()
        {
            return answer.Length;
        }

        public void AddGuess(char guess)
        {
            guesses.Add(guess);
        }

        public string GetGuesses()
        {
            var builder = new StringBuilder();

            foreach(var let in guesses)
            {
                builder.Append($"{let} ");
            }

            return builder.ToString().Trim();
        }

        public string GetAnswerStringToDisplayToUsers()
        {
            var builder = new StringBuilder();

            foreach (var let in answer)
            {
                if (guesses.Contains(let))
                {
                    builder.Append($"{ let } ");
                }
                else
                {
                    builder.Append("_ ");
                }
            }

            return builder.ToString().Trim();
        }

        public bool IsLetterInAnswer(char letter)
        {
            return answer.Contains(letter);
        }

        public bool HasLetterBeenGuessed(char letter)
        {
            return guesses.Contains(letter);
        }

        public bool CheckIfPlayerWon()
        {
            // Extra check.
            if (CheckIfNoLives()) return false;

            foreach (var let in answer)
            {
                if (!guesses.Contains(let)) return false;
            }

            return true;

            

            //public string randomWord = "";
            //public bool result;
            //public char guess;

            //public static bool PlayGame()
            //{
            //    //string randomWord;
            //    var random = new Random();
            //    var list = new List<string> { "Rainbow", "Happy", "Polymorphism", "Abstraction", "Encapsulation" };
            //    int index = random.Next(list.Count);
            //    randomWord = list[index];
            //    Console.WriteLine($"Your word has {randomWord.Length} characters.  Good luck!\n  \n  ");

            //    for(var i = 0; i < randomWord.Length; i++)
            //    {
            //        Console.Write(" * ");
            //    }

            //    Console.WriteLine("Please guess a single letter:");
            //    char guess = Convert.ToChar(Console.ReadLine());
            //    bool result = randomWord.Contains(guess);
            //    Console.WriteLine(result);

            //    return result;
            //}

            //public static string CheckGuess()
            //{

            //}

            // We could not access the randomWord variable from within the method without overloading it.  But overloading breaks the main method
            //public static void GuessLetter()
            //{
            //    Console.WriteLine("Please guess a single letter:");
            //    char guess = Convert.ToChar(Console.ReadLine());
            //    bool result = randomWord.Contains(guess);
            //    Console.WriteLine(result);
            //}
        }
    }
}
