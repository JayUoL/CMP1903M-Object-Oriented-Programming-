using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        public string text = "nothing";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine("Manual Text Input");
            text = Console.ReadLine();
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            string fileText = System.IO.File.ReadAllText(@"C:\Users\Jayde\Downloads\CMP1903M Assessment 1 Base Code (1).zip\CMP1903M Assessment 1 Base Code");
            text = fileText;
            Console.WriteLine(fileText);
            return text;
        }

    }
}
