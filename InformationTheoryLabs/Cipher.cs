using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationTheoryLabs
{
    internal class Cipher
    {
        private string _key;
        private Language _lang;

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
    }
}
