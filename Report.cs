using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        List<int> Parameters;
        

        public Report (string text, List<int> parameters)
        {
            Parameters = parameters;
            Parameters.ToString();
        }


    }

    public void OutputConsole()
    {

        List<string> report = new List<string>()
        {
            "Sentences: " + parameters[0] ,
            "Vowels: " + parameters[1],
            "Consonants: " + parameters[2],
            "Upper Case Letters: " + parameters[3],
            "Lower Case Letters: " + parameters[4]};

        Console.WriteLine(report);
    }
  
}
