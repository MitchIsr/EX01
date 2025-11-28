using System;
using Ex01_01;
using Ex01_01_Utilities;

namespace ProgramStart
{
    public class BinaryNumberProgram
    {
        public static void StartProgram()
        {
            BinaryNumber[] l_BinaryNumberArray = new BinaryNumber[3];

            string Output = @"Hello, Welcome to Ex_01_01 Binary Sequences
Please Enter 3 Numbers In Binary Format With a Length of up to 8:";
            Console.WriteLine(Output);
            for (int i = 0; i < 3; i++)
            {
                l_BinaryNumberArray[i] = new BinaryNumber();
                bool f_isInputValid = false;
                while (f_isInputValid == false)
                {
                    string input = Console.ReadLine();
                    try
                    {
                        l_BinaryNumberArray[i] = l_BinaryNumberArray[i].Parse(input);
                        f_isInputValid = true;
                    }
                    catch (Exception l_invalidinput)
                    {
                        Console.WriteLine(l_invalidinput.Message);
                    }
                }
            }
            BinaryNumberUtilities.quickSort(l_BinaryNumberArray, 0, l_BinaryNumberArray.Length - 1);
            Output = "Decimal numbers in ascending order: ";
            Console.Write(Output);
            for (int i = 0; i < 3; i++)
            {
                l_BinaryNumberArray[i].PrintNumericValue();
                l_BinaryNumberArray[i].PrintBinary();
                if (i < 2)
                {
                    Console.Write(", ");
                }

            }
            float l_BinaryNumbersAverage = BinaryNumberUtilities.Avg(l_BinaryNumberArray[0], l_BinaryNumberArray[1], l_BinaryNumberArray[2]);
            Console.WriteLine();
            Output = $@"Average: {l_BinaryNumbersAverage}";
            Console.WriteLine(Output);
            BinaryNumberUtilities.FindShortestBitSequence(l_BinaryNumberArray);
            Console.WriteLine();
            BinaryNumberUtilities.PrintPalindromesOfBinary(l_BinaryNumberArray);
            Console.WriteLine();
            BinaryNumberUtilities.PrintMaxDifferenceBinary(l_BinaryNumberArray);
            Console.WriteLine();
            BinaryNumberUtilities.PrintNumbersThatStartAndEndWithSameDigit(l_BinaryNumberArray);
            Console.WriteLine();

        }
    }
}
