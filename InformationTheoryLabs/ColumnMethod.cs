using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTheoryLabs
{
    internal class ColumnMethod:Cipher
    {
        public ColumnMethod (string key, Language language)
        {
            this.Key = key;
            this.Lang = language;
        }
        /// <summary>
        /// Code plain text uses column method.
        /// </summary
        /// <returns>Returns cipher text</returns>
        public string encrypt(string plaintext)
        {
            if (Key == "") Key = " ";

            string ciphertext = "";
            string buffKey = Key;

            List<int> notValidLetters = new List<int>();

            int column;

            for (int i = 0; i < Key.Length; i++)
            {
                column = Lang.findNextLetterPos(Key);
                hideLetter(ref buffKey, column);

                for (int j = column; j < plaintext.Length; j += buffKey.Length)
                {
                    if (Lang.isValidLetter(plaintext[j]))
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

        public bool isValidKey()
        {
            for (int i = 0; i < Key.Length; i++)
            {
                if (!Lang.isValidLetter(Key[i]))
                    return false;
            }

            return true;
        }

        
    }
}
