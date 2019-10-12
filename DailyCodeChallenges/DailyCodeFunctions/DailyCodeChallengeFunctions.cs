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
    }
}
