using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace InformationTheoryLabs
{
    public partial class fInformationTheory : Form
    {
        
        private enum Cipher { ColumnarTransposition, Vigenere, DownsamplingMethod};
        private enum ErrorCode { NoErrors, UnknownLanguage, UnknownAlgorithm, NotValidKey};

        // Contains last error.
        private ErrorCode lastError;

        private Language currLang; 
        public fInformationTheory()
        {
            InitializeComponent();

            // Initializes class fields.
            currLang = new Language(Language.Alphabet.English);
            lastError = ErrorCode.NoErrors;

            // Set up combo boxes.
            string[] cipherEncodeTable = { "Столбцовый метод", "Метод Виженера", "Метод децимации" };

            foreach (string cipher in cipherEncodeTable)
                cbCipher.Items.Add(cipher);

            foreach (string alphabet in currLang.AlphabetView)
                cbLanguage.Items.Add(alphabet);
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            if (!isCorrectInput())
            {
                showError();
                return;
            }

            currLang.changeAlphabet((Language.Alphabet)cbLanguage.SelectedIndex);

            encrypt((Cipher)cbCipher.SelectedIndex);

            ColumnMethod columnMethod = new ColumnMethod(tbKey.Text.ToUpper(), currLang);

            if  (!columnMethod.isValidKey())
            {
                lastError = ErrorCode.NotValidKey;
                showError();
                return;
            }

            string ciphertext = columnMethod.encrypt(tbPlaitext.Text);

        }

        private void encrypt(Cipher cipher)
        {
            string ciphertext = "";

            switch (cipher)
            {
                case Cipher.ColumnarTransposition:
                    ColumnMethod columnMethod = new ColumnMethod(tbKey.Text.ToUpper(), currLang);

                    if (!columnMethod.isValidKey())
                    {
                        lastError = ErrorCode.NotValidKey;
                        showError();
                        return;
                    }

                    ciphertext = columnMethod.encrypt(tbPlaitext.Text);

                    break;
            }

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

                case ErrorCode.NotValidKey:
                    stringError = "Ключ содержит недопустимые значения";
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


    }
}
