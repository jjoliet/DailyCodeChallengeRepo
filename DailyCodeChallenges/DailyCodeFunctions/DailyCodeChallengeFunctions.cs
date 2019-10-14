using System;
using System.Collections.Generic;
using System.Text;

namespace DailyCodeChallenges.DailyCodeFunctions
{
    public class DailyCodeChallengeFunctions
    {
        /*
         * Daily Code Challenge One:
         * Your goal is to create a function that removes the first and last letters of a string. 
         * Strings with two characters or less are considered invalid. You can choose to have your 
         * function return null or simply ignore.
         */
         public String StringPeeler(String str)
        {
            if(str == null || str.Length <= 2)
            {
                throw new ArgumentException();
            }

            return str.Substring(1, str.Length-2);
        }

        /*
         * Your task is to return a string that displays a diamond shape on the screen using asterisk (“*”) characters.
         * The shape that the print method will return should resemble a diamond. A number provided as input will represent
         * the number of asterisks printed on the middle line. The line above and below will be centered and will have two less 
         * asterisks than the middle line. This reduction will continue for each line until a line with a single asterisk is printed at 
         * the top and bottom of the figure.
         * Return null if input is an even number or a negative number.
         */

        public void PrintDiamond(int middle)
        {
            String[] lines = makeBottomDiamondArray(middle);
            if(lines != null) { 
                printUpperDiamond(lines, middle);
                printLowerDiamond(lines, middle);
            }
        }
        private String[] makeBottomDiamondArray(int middle)
        {
            if (!ValidNumber(middle))
            {
                return null;
            }
            String[] diamondLines = new String[(middle + 1) / 2];
            for(int i = 0; i < diamondLines.Length; i++)
            {
                diamondLines[i] = new string('*', (middle - i * 2));
            }
            return diamondLines;
        }

        private void printUpperDiamond(String[] lines, int maxLength)
        {
            for(int i = lines.Length-1; i >= 1; i--)
            {
                Console.WriteLine(lines[i].PadLeft(maxLength - i));
            }
        }
        
        private void printLowerDiamond(String[] lines, int maxLength)
        {
            for(int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i].PadLeft(maxLength - i));
            }
        }
        /*
         * Verify the number is not even and the number is not a negative value
         */
        public Boolean ValidNumber(int number)
        {
            return !(number % 2 == 0 || number < 0);
        }

    }
}
