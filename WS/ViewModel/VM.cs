using System;
using System.Collections.Generic;
using System.Text;
using WS.Model;

namespace WS.ViewModel
{
    class VM
    {
        WordModel word = new WordModel();
        
        public string ToUpperCaseText(string readWord)
        {
            int l = 0;

            foreach (char chr in readWord)
            {
                l += 1;
            }

            if (l == 0)
            {
                throw new ArgumentNullException(paramName : nameof(readWord),message: "Veuillez rentrer un quelque chose");
            }
            else if (l > 8)
            {
                throw new ArgumentException(paramName: nameof(readWord), message: "Seulement 8 charactères ou moins");
            }

            else
            {

                readWord = readWord.ToUpper();

                word.Word = readWord;

                return word.Word;
            }
        }
    }
}
