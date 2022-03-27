using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        List<int> values = new List<int>();

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
    }

    public List<int> analyseText(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            values.add(0);
        }

        int g, len;

        //length of sentance input
        len = input.Length;

        //the number of sentances input
        for (g = 0; g < len; g++)
        {
            if (input[g] == '.')
            {
                values[0]++;
            }
        }

        //The vowels input
        if (input[g] == 'a' || input[g] == 'i' || input[g] == 'u' || input[g] == 'e' || input[g] == 'o' ||
            input[g] == 'A' || input[g] == 'I' || input[g] == 'U' || input[g] == 'E' || input[g] == 'O')
            
        {
            values[1]++;
        }

        //The consonants input
        else if (input[g] >= 'a' && input[g] <= 'z' ||
                 input[g] >= 'A' && input[g] <= 'Z')
        {
            values[2]++;
        }

        //Upper case characters input
        if (char.IsUpper(input[g]))
        {
            values[3]++;
            values[5]++;
        }

        //Lower case characters input
        if (char.IsLower(input[g]))
        {
            values[4]++;
            values[5]++;
        }

        return values;


    }

    public List<int> GetList()
    {
        return values;
    }
}










