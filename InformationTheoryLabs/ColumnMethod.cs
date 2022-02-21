using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTheoryLabs
{
    internal class ColumnMethod
    {

        /// <summary>
        /// Code plain text uses column method.
        /// </summary
        /// <returns>Returns cipher text</returns>
        public static string encrypt(string plaintext, string key, Language lang)
        {
            if (key == "") key = " ";

            char[,] matrix = createMatrix(plaintext, key, lang);
            int matrixRows = matrix.GetUpperBound(0) + 1;
            int matrixColumns = matrix.Length / matrixRows;

            string ciphertext = "";

            List<int> notValidLetters = new List<int>();

            for (int j = 0; j < matrixColumns; j++)
            {
                int column = lang.findNextLetterPos(key);
                hideLetter(ref key, column);

                for (int i = 0; i < matrixRows; i++)
                {
                    if (matrix[i, column] != (char)0)
                    {
                        if (lang.isValidLetter(matrix[i, column]))
                            ciphertext += matrix[i, column];
                    }
                }
            }

            ciphertext = insertNotValidLetters(plaintext, ciphertext, lang);

            return ciphertext;
        }


        /// <summary>
        /// Replace symbol in word[pos] with 0 symbol
        /// </summary>
        /// <param name="word">is plain word</param>
        /// <param name="pos">is position hided letter</param>
        private static void hideLetter(ref string word, int pos)
        {
            StringBuilder buff = new System.Text.StringBuilder(word);
            buff[pos] = (char)0;
            word = buff.ToString();
        }

        public static bool isValidKey(string key, Language lang)
        {
            for (int i = 0; i < key.Length; i++)
            {
                if (!lang.isValidLetter(key[i]))
                    return false;
            }

            return true;
        }

        private static char[,] createMatrix(string plaintext, string key, Language lang)
        {
            char[,] matrix = new char[plaintext.Length, key.Length];

            int i = 0;
            int j = 0;
            int currLetter = 0;

            while (currLetter < plaintext.Length)
            {
                int column = lang.findNextLetterPos(key);
                hideLetter(ref key, column);

                for (j = 0; j <= column && currLetter < plaintext.Length; j++)
                {
                    matrix[i, j] = plaintext[currLetter];
                    currLetter++;
                }

                i++;
            }

            return matrix;

        }

        private static string insertNotValidLetters (string plaintext, string ciphertext, Language lang)
        {
            if (plaintext.Length == ciphertext.Length) return ciphertext;

            for (int i = 0; i < plaintext.Length; i++)
            {
                if (!lang.isValidLetter(plaintext[i]))
                    ciphertext = ciphertext.Insert(i, Char.ConvertFromUtf32(plaintext[i]));
            }

            return ciphertext;
        }
    }
}
