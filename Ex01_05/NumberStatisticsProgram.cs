using System;
using NumberStats;

namespace ProgramStart
{
    class NumberStatisticsProgram
    {
        public static void StartProgram()
        {
            string Output = @"Hello, Welcome to Ex01_05 Numbers Statistics
Please Enter a Number With a length of 7:";
            Console.WriteLine(Output);
            NumberStatistics i_numberinput = new NumberStatistics();
            bool isInputValid = false;
            while (isInputValid == false)
            {
                string i_input = Console.ReadLine();
                try
                {
                    i_numberinput = NumberStatistics.Parse(i_input);
                    isInputValid = true;
                }
                catch (Exception l_invalidinput)
                {
                    Console.WriteLine(l_invalidinput.Message);
                }
            }
            i_numberinput.PrintCountDigitsBiggerThanFirstDigit();
            i_numberinput.PrintHowManyDigitsDevidedBy3Counter();
            i_numberinput.PrintDifferenceBetweenMaxDigitAndMinDigit();
            i_numberinput.PrintMostCommonDigit();
        }
    }
}
