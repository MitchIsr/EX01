using System;
using NumberStats;

namespace ProgramStart
{
    class NumberStatisticsProgram
    {
        public static void StartProgram()
        {
            string l_Output = @"Hello, Welcome to Ex01_05 Numbers Statistics
Please Enter a Number With a length of 7:";
            Console.WriteLine(l_Output);
            NumberStatistics l_Numberinput = new NumberStatistics();
            bool v_isInputValid = false;
            while (v_isInputValid == false)
            {
                string l_input = Console.ReadLine();
                try
                {
                    l_Numberinput = NumberStatistics.Parse(l_input);
                    v_isInputValid = true;
                }
                catch (Exception l_invalidinput)
                {
                    Console.WriteLine(l_invalidinput.Message);
                }
            }
            l_Numberinput.PrintCountDigitsBiggerThanFirstDigit();
            l_Numberinput.PrintHowManyDigitsDevidedBy3Counter();
            l_Numberinput.PrintDifferenceBetweenMaxDigitAndMinDigit();
            l_Numberinput.PrintMostCommonDigit();
        }
    }
}
