using System;
using Ex01_01;
using Ex01_01_Utilities;

namespace ProgramStart
{
    public class BinaryNumberProgram
    {
        public static void StartProgram()
        {
            BinaryNumber[] i_binaryNumberArray = new BinaryNumber[3];

            string output = @"Hello, Welcome to Ex_01_01 Binary Sequences
Please Enter 3 Numbers In Binary Format With a Length of up to 8:";
            Console.WriteLine(output);
            for (int i = 0; i < 3; i++)
            {
                i_binaryNumberArray[i] = new BinaryNumber();
                bool isInputValid = true;
                while (!isInputValid == false)
                {
                    string i_binaryNumber = Console.ReadLine();

                    try
                    {
                        i_binaryNumberArray[i] = i_binaryNumberArray[i].Parse(i_binaryNumber);
                        isInputValid = false;
                    }
                    catch (Exception l_invalidinput)
                    {
                        Console.WriteLine(l_invalidinput.Message);
                    }
                }
            }

            BinaryNumberUtilities.quickSort(i_binaryNumberArray, 0, i_binaryNumberArray.Length - 1);
            output = "Decimal numbers in ascending order: ";
            Console.Write(output);

            for (int i = 0; i < 3; i++)
            {
                i_binaryNumberArray[i].PrintNumericValue();
                i_binaryNumberArray[i].PrintBinary();
                if (i < 2)
                {
                    Console.Write(", ");
                }

            }
            float l_binaryNumbersAverage = BinaryNumberUtilities.Avg(i_binaryNumberArray[0], i_binaryNumberArray[1], i_binaryNumberArray[2]);
            Console.WriteLine();

            output = $@"Average: {l_binaryNumbersAverage}";
            Console.WriteLine(output);

            BinaryNumberUtilities.FindShortestBitSequence(i_binaryNumberArray);
            Console.WriteLine();

            BinaryNumberUtilities.PrintPalindromesOfBinary(i_binaryNumberArray);
            Console.WriteLine();

            BinaryNumberUtilities.PrintMaxDifferenceBinary(i_binaryNumberArray);
            Console.WriteLine();

            BinaryNumberUtilities.PrintNumbersThatStartAndEndWithSameDigit(i_binaryNumberArray);
            Console.WriteLine();

        }
    }
}
