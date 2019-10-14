using DailyCodeChallenges.DailyCodeFunctions;
using System;

namespace DailyCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            DailyCodeChallengeFunctions dailyCode = new DailyCodeChallengeFunctions();
            Console.WriteLine(dailyCode.StringPeeler("Today"));

            dailyCode.PrintDiamond(9);
        }
    }
}
