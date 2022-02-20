using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
//using ColumnMethod;

namespace InformationTheoryLabs
{
    public partial class fInformationTheory : Form
    {
        private enum Alphabet { English, Russian};
        private enum Cipher { ColumnarTransposition, Vigenere, DownsamplingMethod};
        private enum ErrorCode { NoErrors, UnknownLanguage, UnknownAlgorithm};

        // Contains last error.
        private ErrorCode lastError = ErrorCode.NoErrors;

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
            if (!isCorrectInput())
            {
                showError();
                return;
            }


            ColumnMethod columnMethod = new ColumnMethod(tbKey.Text.ToUpper(),
                firstAlphabetLetter, lastAlphabetLetter);

            setUpAlphabet((Alphabet)cbLanguage.SelectedIndex);
            string ciphertext = columnMethod.encrypt(tbPlaitext.Text);

            tpCiphertext.Text = ciphertext;

        }

        /// <summary>
        /// Creates error message.
        /// <para>Error code contains in variable lastError.</para>
        /// </summary>
        private void showError()
        {
            string stringError = "";
            switch (lastError)
            {
                case ErrorCode.NoErrors:
                    stringError = "Нет ошибок";
                    break;

                case ErrorCode.UnknownLanguage:
                    stringError = "Выберете язык";
                    break;

                case ErrorCode.UnknownAlgorithm:
                    stringError = "Выберете алгоритм шифрования";
                    break;
            }

            lastError = ErrorCode.NoErrors;
            MessageBox.Show(stringError, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Checks all fields in program
        /// </summary>
        /// <returns>Returns true if all correct</returns>
        private bool isCorrectInput()
        {
            if (cbLanguage.SelectedIndex == -1)
            {
                lastError = ErrorCode.UnknownLanguage;
                return false; 
            } 
            if (cbCipher.SelectedIndex == -1)
            {
                lastError = ErrorCode.UnknownAlgorithm;
                return false;
            }
            

            return true;
        }

        /// <summary>
        /// Changes fields firstAlphabetLetter and lastAlphabetLetter
        /// </summary>
        private void setUpAlphabet(Alphabet alpabet)
        {
            switch (alpabet)
            {
                case Alphabet.English:
                    firstAlphabetLetter = 'A';
                    lastAlphabetLetter = 'Z';
                    break;

                case Alphabet.Russian:
                    firstAlphabetLetter = 'А';
                    lastAlphabetLetter = 'Я';
                    break;
            }

        }

    }
}
