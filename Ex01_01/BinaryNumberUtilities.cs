using System;
using System.Collections.Generic;
using Ex01_01;

namespace Ex01_01_Utilities
{
   public class BinaryNumberUtilities
    {
        public static void Swap(ref int i_Number1,ref int i_Number2)
        {
            int l_TempNumber = i_Number1;
            i_Number1 = i_Number2;
            i_Number2 = l_TempNumber;
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
            int l_BinaryNumber1Dec = i_binaryNumber1.GetNumericValue();
            int l_BinaryNumber2Dec = i_binaryNumber2.GetNumericValue();
            int l_BinaryNumber3Dec = i_binaryNumber3.GetNumericValue();

            return ((float)(l_BinaryNumber1Dec + l_BinaryNumber2Dec + l_BinaryNumber3Dec) / 3);
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


        public static int PartitionBinArray(BinaryNumber[] i_BinaryNumbersArray, int i_low, int i_high)
        {

            int l_PivotValue = i_BinaryNumbersArray[i_high].GetNumericValue();
            int i = i_low - 1;

            for (int j = i_low; j < i_high; j++)
            {
                if (i_BinaryNumbersArray[j].GetNumericValue() <= l_PivotValue)
                {
                    i++;
                    SwapArrayValue(ref i_BinaryNumbersArray, i, j);
                }
            }
            SwapArrayValue(ref i_BinaryNumbersArray, i + 1, i_high);
            return i + 1;
        }

        public static void SwapArrayValue(ref BinaryNumber[] i_BinaryNumbersArray, int i, int j)
        {
            BinaryNumber l_temp = i_BinaryNumbersArray[i];
            i_BinaryNumbersArray[i] = i_BinaryNumbersArray[j];
            i_BinaryNumbersArray[j] = l_temp;
        }

        public static void FindShortestBitSequence(BinaryNumber[] i_BinaryNumbersArray)
        {
            int[] l_LengthOfBitSequenceBinNumberArray = new int[i_BinaryNumbersArray.Length];
            for (int i = 0; i < i_BinaryNumbersArray.Length; i++)
            {
                l_LengthOfBitSequenceBinNumberArray[i] = i_BinaryNumbersArray[i].GetShortestBitSequence();
            }
            int l_MinimumSequence = Math.Min(l_LengthOfBitSequenceBinNumberArray[0], Math.Min(l_LengthOfBitSequenceBinNumberArray[1], l_LengthOfBitSequenceBinNumberArray[2]));

            string l_Output = $@"Shortest bit sequence: {l_MinimumSequence} ";
            Console.Write(l_Output);

            int l_ShortSequenceCounter = 0;
            for (int i = 0; i < 3; i++)
            {
                if (l_LengthOfBitSequenceBinNumberArray[i] == l_MinimumSequence)
                {
                    l_ShortSequenceCounter++;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (l_LengthOfBitSequenceBinNumberArray[i] == l_MinimumSequence)
                {
                    i_BinaryNumbersArray[i].PrintBinary();
                    if (i < l_ShortSequenceCounter-1)
                    {
                        Console.Write(", ");
                    }
                }

            }
        }
        public static void PrintPalindromesOfBinary(BinaryNumber[] i_BinaryNumbersArray)
        {
            int l_PalindromeCounter = 0, l_i = 0; ;
            List<BinaryNumber> l_ListOfBinaryPalindromes = new List<BinaryNumber>();

            for(int i =0;i<3;i++)
            {
                if(i_BinaryNumbersArray[i].IsPalindrome())
                {
                    l_PalindromeCounter++;
                    l_ListOfBinaryPalindromes.Add(i_BinaryNumbersArray[i]);
                }
            }
 
            string l_output = $@"Number of Palindromes : {l_PalindromeCounter} ";
            Console.Write(l_output);

            foreach (BinaryNumber l_Node in l_ListOfBinaryPalindromes)
            {
                l_Node.PrintBinary();
                if (l_i < l_PalindromeCounter - 1)
                {
                    l_i++;
                    Console.Write(", ");
                }
            }
        }
        public static void PrintMaxDifferenceBinary(BinaryNumber[] i_BinaryNumbersArray)
        {
            string l_output = @"Number with maximum difference between 1s and 0s: ";
            Console.Write(l_output);

            List<BinaryNumber> l_ListOfBinaryWithMaxDifference = new List<BinaryNumber>();
            int l_MaxDifference = 0;

            foreach (BinaryNumber l_BinaryNumber in i_BinaryNumbersArray)
            {
                int l_Difference = l_BinaryNumber.Get1sAnd0sDifference();
                if (l_Difference>l_MaxDifference)
                {
                    l_MaxDifference = l_Difference;
                }
            }

            foreach(BinaryNumber l_BinaryNumber in i_BinaryNumbersArray)
            {
                if(l_BinaryNumber.Get1sAnd0sDifference()==l_MaxDifference)
                {
                    l_BinaryNumber.PrintBinary();
                    break;
                }
            }
           
            l_output = $@" - Difference of {l_MaxDifference}";
            Console.Write(l_output);
        }
        public static void PrintNumbersThatStartAndEndWithSameDigit(BinaryNumber[] i_BinaryNumbersArray)
        {
            string l_output = @"Numbers that start and end with same digit: ";
            Console.Write(l_output);
            List<BinaryNumber> l_ListOfBinaryThatStartAndEndWithSameDigit = new List<BinaryNumber>();
            int l_Counter = 0, i = 0;

            foreach (BinaryNumber l_BinaryNumber in i_BinaryNumbersArray)
            {
                if (l_BinaryNumber.IsStartAndEndWithSameDigit() == true)
                {
                    l_ListOfBinaryThatStartAndEndWithSameDigit.Add(l_BinaryNumber);
                    l_Counter++;
                }
            }

            l_output = $@"{l_Counter} ";
            Console.Write(l_output);

            foreach(BinaryNumber l_BinaryNumber in l_ListOfBinaryThatStartAndEndWithSameDigit)
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