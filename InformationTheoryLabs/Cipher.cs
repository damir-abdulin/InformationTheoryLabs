using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTheoryLabs
{
    internal class Cipher
    {
        public enum TypeCipher { ColumnarTransposition, Vigenere, DownsamplingMethod };
        public string[] TypeCipherView = { "Столбцовый метод", "Метод Виженера", "Метод децимации" };

        private string _key;
        private Language _lang;

        private TypeCipher _typeCipher;

        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }
        public Language Lang
        {
            get { return _lang; }
            set { _lang = value; }
        }

        public Cipher()
        {
            _typeCipher = TypeCipher.ColumnarTransposition;
            _key = "";
        }

        public bool isValidKey()
        {
            switch (_typeCipher)
            {
                case TypeCipher.ColumnarTransposition:
                    return ColumnMethod.isValidKey(_key, _lang);
            }

            return false;
        }

        public void changeCipher(TypeCipher cipher, string key, Language lang) 
        {
            _typeCipher = cipher;
            _key = key.ToUpper();
            _lang = lang;
        }

        public string encrypt(string plaintext)
        {
            switch (_typeCipher)
            {
                case TypeCipher.ColumnarTransposition:
                    return ColumnMethod.encrypt(plaintext, _key, _lang);
            }

            return "";
        }
    }
}
