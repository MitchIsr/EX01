using System;
using NumberStats;

namespace Project1
{
    class main
    {
        static void Main()
        {
            string Output = @"Hello, Welcome to Ex01_05 Numbers Statistics
Please Enter a Number With a length of 7:";
            Console.WriteLine(Output);
            NumberStatistics l_Numberinput = new NumberStatistics();
            bool f_isInputValid = false;
            while (f_isInputValid == false)
            {
                string input = Console.ReadLine();
                try
                {
                    l_Numberinput = NumberStatistics.Parse(input);
                    f_isInputValid = true;
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
