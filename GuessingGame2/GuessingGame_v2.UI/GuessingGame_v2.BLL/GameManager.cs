using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // using

namespace GuessingGame_v2.BLL  // namespace
{
    public class GameManager  // class
    {
        private int _answer; // class w/data field

        private bool IsValidGuess(int guess) // class w/data field (& variable data field)
        {
            if (guess >= 1 && guess <= 20) // function
                return true;  // return value
            else
                return false;  // return value
        }

        private void CreateRandomAnswer() // method statement w/data field (&variable data field)
        {
            Random rng = new Random(); // function
            _answer = rng.Next(1, 21); // return value
        }

        public GuessResult ProcessGuess(int guess)
        {
            if (!IsValidGuess(guess))
                return GuessResult.Invalid;

            if (guess < _answer)
                return GuessResult.Higher;
            else if (guess > _answer)
                return GuessResult.Lower;
            else
                return GuessResult.Victory;
        }

        public void Start()
        {
            CreateRandomAnswer();
        }

        // testing static answer 

        public void Start(int answer)
        {
            _answer = 7;
        }
    }
}
