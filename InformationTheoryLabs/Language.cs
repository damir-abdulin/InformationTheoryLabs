using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTheoryLabs
{
    internal class Language
    {
        public enum Alphabet { English, Russian };
        public string[] AlphabetView = { "Английский", "Русский" };

        private Alphabet alphabet;

        private char firstLetter;
        private char lastLetter;

        public Language(Alphabet alphabet) { changeAlphabet(alphabet); }

        /// <summary>
        /// Changes language fields
        /// </summary>
        /// <param name="alphabet">is new alphabet</param>
        public void changeAlphabet(Alphabet alphabet)
        {
            this.alphabet = alphabet;

            switch (alphabet)
            {
                case Alphabet.English:
                    firstLetter = 'A';
                    lastLetter = 'Z';
                    break;

                case Alphabet.Russian:
                    firstLetter = 'А';
                    lastLetter = 'Я';
                    break;
            }
        }

        /// <summary>
        /// Finds position in word letter with minimal alphabet index
        /// </summary>
        /// <param name="word"></param>
        /// <returns>Returns position in word</returns>
        public int findNextLetterPos(string word)
        {
            char currLetter = firstLetter;
            int pos;

            while (currLetter <= lastLetter)
            {
                pos = word.IndexOf(currLetter);

                if (pos != -1)
                {
                    return pos;
                }

                currLetter++;
            }

            // Return last not zero symbol.
            pos = 0;
            while (pos < word.Length && word[pos] == (char)0)
                pos++;

            if (pos >= word.Length)
                return pos-1;
            else
                return pos;
        }

        /// <summary>
        /// Checks symbol is valid or not.
        /// </summary>
        /// <param name="letter">is checked symbol</param>
        /// <returns>Returns true if symbol is valid</returns>
        public bool isValidLetter(char letter)
        {
            letter = Char.ToUpper(letter);
            return (letter >= firstLetter && letter <= lastLetter);
        }
    }
}
