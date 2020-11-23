using System;
using System.Collections.Generic;
using System.Text;
using WS.ViewModel;

namespace WS.View
{
    class Display
    {
        VM mv = new ViewModel.VM();
        string readWord;


        public void Start()
        {
            DisplayText();
            ReadInput();
            mv.ToUpperCaseText(readWord);
            DisplayTextFinished();
        }

        public void DisplayText()
        {
            Console.WriteLine("Veuillez entrer un mot de 8 charactères maxium.");
        }

        public void DisplayTextFinished()
        {
            Console.WriteLine(mv.ToUpperCaseText(readWord));
        }

        public string ReadInput()
        {
            readWord = Console.ReadLine();
            return readWord;
        }
    }
}
