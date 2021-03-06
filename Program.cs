//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input input = new Input();
            input.manualTextInput();
            input.fileTextInput("a");

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            Analyse analyse = new Analyse();
            analyse.analyseText(input.text);

            //Receive a list of integers back
            analyse.GetList();

            //Report the results of the analysis
            Report report = new Report();  

            //TO ADD: Get the frequency of individual letters?
                       
        }              
    
    }
}
