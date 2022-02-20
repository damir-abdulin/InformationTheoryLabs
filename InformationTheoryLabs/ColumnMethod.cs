using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTheoryLabs
{
    internal class ColumnMethod
    {
        private char firstAlphabetLetter, lastAlphabetLetter;
        private string key;

        public ColumnMethod (string key, char firstLetter, char lastLetter)
        {
            this.firstAlphabetLetter = firstLetter;
            this.lastAlphabetLetter = lastLetter;
            this.key = key;
        }
        /// <summary>
        /// Code plain text uses column method.
        /// </summary
        /// <returns>Returns cipher text</returns>
        public string encrypt(string plaintext)
        {
            if (key == "") key = " ";

            string ciphertext = "";

            List<int> notValidLetters = new List<int>();

            int column;

            for (int i = 0; i < key.Length; i++)
            {
                column = findNextLetterPos(key);
                hideLetter(ref key, column);

                for (int j = column; j < plaintext.Length; j += key.Length)
                {
                    if (isValidLetter(plaintext[j]))
                        ciphertext += plaintext[j];
                    else
                        notValidLetters.Add(j);
                }
            }

            // Insert not valid letters from plain text to cipher.
            notValidLetters.Sort();
            foreach (int i in notValidLetters)
                ciphertext = ciphertext.Insert(i, Char.ConvertFromUtf32(plaintext[i]));


            return ciphertext;
        }

        /// <summary>
        /// Finds position in word letter with minimal alphabet index
        /// </summary>
        /// <param name="word"></param>
        /// <returns>Returns position in word</returns>
        private int findNextLetterPos(string word)
        {
            char currLetter = firstAlphabetLetter;
            int pos;

            while (currLetter <= lastAlphabetLetter)
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
                return pos--;
            else
                return pos;
        }

        /// <summary>
        /// Replace symbol in word[pos] with 0 symbol
        /// </summary>
        /// <param name="word">is plain word</param>
        /// <param name="pos">is position hided letter</param>
        private void hideLetter(ref string word, int pos)
        {
            StringBuilder buff = new System.Text.StringBuilder(word);
            buff[pos] = (char)0;
            word = buff.ToString();
        }

        /// <summary>
        /// Checks symbol is valid or not.
        /// </summary>
        /// <param name="letter">is checked symbol</param>
        /// <returns>Returns true if symbol is valid</returns>
        private bool isValidLetter(char letter)
        {
            letter = Char.ToUpper(letter);
            return (letter >= firstAlphabetLetter && letter <= lastAlphabetLetter);
        }
    }
}
