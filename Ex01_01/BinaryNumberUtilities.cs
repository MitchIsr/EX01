using System;
using System.Collections.Generic;
using Ex01_01;

namespace Ex01_01_Utilities
{
   public class BinaryNumberUtilities
    {
        public static void Swap(ref int i_number1,ref int i_number2)
        {
            int l_tempNumber = i_number1;
            i_number1 = i_number2;
            i_number2 = l_tempNumber;
        }
        public static int Absolute(int i_Number1, int i_Number2)
        {
            if(i_Number1<i_Number2)
            {
                Swap(ref i_Number1,ref i_Number2);
            }

            return i_Number1 - i_Number2;
        }

        public static float Avg(BinaryNumber i_binaryNumber1, BinaryNumber i_binaryNumber2, BinaryNumber i_binaryNumber3)
        {
            int o_binaryNumber1Dec = i_binaryNumber1.GetNumericValue();
            int o_binaryNumber2Dec = i_binaryNumber2.GetNumericValue();
            int o_binaryNumber3Dec = i_binaryNumber3.GetNumericValue();

            return ((float)(o_binaryNumber1Dec + o_binaryNumber2Dec + o_binaryNumber3Dec) / 3);
        }



        public static void quickSort(BinaryNumber[] i_BinaryNumbersArray, int i_low, int i_high)
        {
            if (i_low < i_high)
            {
                int p = PartitionBinArray(i_BinaryNumbersArray, i_low, i_high);
                quickSort(i_BinaryNumbersArray, i_low, p - 1);
                quickSort(i_BinaryNumbersArray, p + 1, i_high);
            }
        }


        public static int PartitionBinArray(BinaryNumber[] io_BinaryNumbersArray, int i_low, int i_high)
        {

            int l_pivotValue = io_BinaryNumbersArray[i_high].GetNumericValue();
            int i = i_low - 1;

            for (int j = i_low; j < i_high; j++)
            {
                if (io_BinaryNumbersArray[j].GetNumericValue() <= l_pivotValue)
                {
                    i++;
                    SwapArrayValue(ref io_BinaryNumbersArray, i, j);
                }
            }
            SwapArrayValue(ref io_BinaryNumbersArray, i + 1, i_high);
            return i + 1;
        }

        public static void SwapArrayValue(ref BinaryNumber[] io_BinaryNumbersArray, int i, int j)
        {
            BinaryNumber l_temp = io_BinaryNumbersArray[i];
            io_BinaryNumbersArray[i] = io_BinaryNumbersArray[j];
            io_BinaryNumbersArray[j] = l_temp;
        }

        public static void FindShortestBitSequence(BinaryNumber[] i_BinaryNumbersArray)
        {
            int[] lo_lengthOfBitSequenceBinNumberArray = new int[i_BinaryNumbersArray.Length];
            for (int i = 0; i < i_BinaryNumbersArray.Length; i++)
            {
                lo_lengthOfBitSequenceBinNumberArray[i] = i_BinaryNumbersArray[i].GetShortestBitSequence();
            }
            int o_minimumSequence = Math.Min(lo_lengthOfBitSequenceBinNumberArray[0], Math.Min(lo_lengthOfBitSequenceBinNumberArray[1], lo_lengthOfBitSequenceBinNumberArray[2]));

            string output = $@"Shortest bit sequence: {o_minimumSequence} ";
            Console.Write(output);

            int o_shortSequenceCounter = 0;
            for (int i = 0; i < 3; i++)
            {
                if (lo_lengthOfBitSequenceBinNumberArray[i] == o_minimumSequence)
                {
                    o_shortSequenceCounter++;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (lo_lengthOfBitSequenceBinNumberArray[i] == o_minimumSequence)
                {
                    i_BinaryNumbersArray[i].PrintBinary();
                    if (i < o_shortSequenceCounter-1)
                    {
                        Console.Write(", ");
                    }
                }

            }
        }
        public static void PrintPalindromesOfBinary(BinaryNumber[] i_BinaryNumbersArray)
        {
            int o_palindromeCounter = 0, j = 0;
            List<BinaryNumber> lo_listOfBinaryPalindromes = new List<BinaryNumber>();

            for (int i = 0; i < 3; i++)
            {
                if (i_BinaryNumbersArray[j].IsPalindrome())
                {
                    o_palindromeCounter++;
                    lo_listOfBinaryPalindromes.Add(i_BinaryNumbersArray[j]);
                }
            }

            string output = $@"Number of Palindromes : {o_palindromeCounter} ";
            Console.Write(output);

            foreach (BinaryNumber o_node in lo_listOfBinaryPalindromes)
            {
                o_node.PrintBinary();
                if (j < o_palindromeCounter - 1)
                {
                    j++;
                    Console.Write(", ");
                }
            }
        }
        public static void PrintMaxDifferenceBinary(BinaryNumber[] i_BinaryNumbersArray)
        {
            string output = @"Number with maximum difference between 1s and 0s: ";
            Console.Write(output);

            int o_maxDifference = 0;
            foreach (BinaryNumber l_binaryNumber in i_BinaryNumbersArray)
            {
                int l_difference = l_binaryNumber.Get1sAnd0sDifference();
                if (l_difference>o_maxDifference)
                {
                    o_maxDifference = l_difference;
                }
            }

            foreach(BinaryNumber l_binaryNumber in i_BinaryNumbersArray)
            {
                if(l_binaryNumber.Get1sAnd0sDifference()==o_maxDifference)
                {
                    l_binaryNumber.PrintBinary();
                    break;
                }
            }
           
            output = $@" - Difference of {o_maxDifference}";
            Console.Write(output);
        }

        public static void PrintNumbersThatStartAndEndWithSameDigit(BinaryNumber[] i_BinaryNumbersArray)
        {
            string l_output = @"Numbers that start and end with same digit: ";
            Console.Write(l_output);
            List<BinaryNumber> l_listOfBinaryThatStartAndEndWithSameDigit = new List<BinaryNumber>();
            int l_Counter = 0, i = 0;

            foreach (BinaryNumber l_binaryNumber in i_BinaryNumbersArray)
            {
                if (l_binaryNumber.IsStartAndEndWithSameDigit() == true)
                {
                    l_listOfBinaryThatStartAndEndWithSameDigit.Add(l_binaryNumber);
                    l_Counter++;
                }
            }

            l_output = $@"{l_Counter} ";
            Console.Write(l_output);

            foreach(BinaryNumber l_BinaryNumber in l_listOfBinaryThatStartAndEndWithSameDigit)
            {
                l_BinaryNumber.PrintBinary();
                if(i<l_Counter-1)
                {
                    i++;
                    Console.Write(", ");
                }
            }

        }
    }
}