﻿using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace InformationTheoryLabs
{
    public partial class fInformationTheory : Form
    {
        private enum Alphabet { alEnglish, alRussian};
        private enum Cipher { cpColumnarTransposition, cpVigenere, cpDownsamplingMethod};


        private char firstAlphabetLetter = 'A';
        private char lastAlphabetLetter = 'Z';

        public fInformationTheory()
        {
            InitializeComponent();

            // Set up combo boxes.
            string[] alphabetEncodeTable = { "Английский", "Русский" };
            string[] cipherEncodeTable = { "Столбцовый метод", "Метод Виженера", "Метод децимации" };

            foreach (string cipher in cipherEncodeTable)
                cbCipher.Items.Add(cipher);

            foreach (string alphabet in alphabetEncodeTable)
                cbLanguage.Items.Add(alphabet);
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            setUpAlphabet((Alphabet)cbLanguage.SelectedIndex);
            string ciphertext = codeByСolumnMethod(tbPlaitext.Text, tbKey.Text.ToUpper());

            tpCiphertext.Text = ciphertext;

        }

        /// <summary>
        /// Changes fields firstAlphabetLetter and lastAlphabetLetter
        /// </summary>
        private void setUpAlphabet(Alphabet alpabet)
        {
            switch (alpabet)
            {
                case Alphabet.alEnglish:
                    firstAlphabetLetter = 'A';
                    lastAlphabetLetter = 'Z';
                    break;

                case Alphabet.alRussian:
                    firstAlphabetLetter = 'А';
                    lastAlphabetLetter = 'Я';
                    break;
            }

        }

        /// <summary>
        /// Code plain text uses column method.
        /// </summary
        /// <returns>Returns cipher text</returns>
        private string codeByСolumnMethod(string plaintext, string key)
        {
            string ciphertext = "";

            List<int> notValidLetters = new List<int>(); 
            
            int column;

            for (int i = 0; i < key.Length; i++)
            {
                column = findNextLetterPos(key);
                hideLetter(ref key, column);

                for (int j = column; j < plaintext.Length; j+=key.Length)
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
            char currLetter = this.firstAlphabetLetter;

            while (currLetter <= lastAlphabetLetter)
            {
                int pos = word.IndexOf(currLetter);

                if (pos != -1)
                {                   
                    return pos;
                }

                currLetter++;
            }

            return currLetter;
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
            return (letter >= this.firstAlphabetLetter && letter <= this.lastAlphabetLetter);
        }
    }
}
