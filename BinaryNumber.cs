using System;
using System.Collections.Generic;
using System.Linq;
using Ex01_01_Utilities;
namespace Ex01_01
{
    public class BinaryNumber
    {
        private int[] m_BinaryNum;
        private int m_NumericValue;
        public BinaryNumber()
        {
            m_BinaryNum = new int[8];
            m_NumericValue = 0;
        }
        public BinaryNumber(int[] i_BinaryNum)
        {
            m_BinaryNum = new int[8];
            for (int i = 0; i < 8; i++)
            {
                m_BinaryNum[i] = i_BinaryNum[i];
            }
            m_NumericValue = ConvertToBase10();
        }
        /* public int[] GetBinaryNumber()
         {
             return m_BinaryNum[];
         }*/
        public int GetBinaryDigit(int Index)
        {
            return this.m_BinaryNum[Index];
        }

        public int GetNumericValue()
        {
            return m_NumericValue;
        }
        public static bool CheckIfLengthIs8(string i_BinaryNumberstr)
        {
            return i_BinaryNumberstr.Length == 8;
        }

        public static bool CheckIfContainDigit1And0(string i_BinaryNumberStr)
        {
            bool l_isBinaryDigit = false;
            for (int i = 0; i < i_BinaryNumberStr.Length; i++)
            {
                l_isBinaryDigit = !(i_BinaryNumberStr[i] != '0' && i_BinaryNumberStr[i] != '1');
                if (l_isBinaryDigit == false)
                    break;
            }
            return l_isBinaryDigit;
        }
        public int ConvertToBase10()
        {
            int l_SumOfBinary = 0;
            for (int i = 0, Current_index_rep = 1; i < 8; i++, Current_index_rep *= 2)
            {
                l_SumOfBinary += (Current_index_rep * m_BinaryNum[i]);
            }
            return l_SumOfBinary;
        }



        public static bool CheckUserInput(string i_BinaryNumberStr)
        {
            return CheckIfContainDigit1And0(i_BinaryNumberStr) && CheckIfLengthIs8(i_BinaryNumberStr);
        }

        public BinaryNumber Parse(string i_BinaryNumberStr)
        {
            int Sizeofinput = i_BinaryNumberStr.Length;

            bool l_isUserinputValid = CheckUserInput(i_BinaryNumberStr);
            if (l_isUserinputValid == true)
            {
                int io_input = int.Parse(i_BinaryNumberStr);
                int[] l_TempArr = new int[8];
                for (int i = 0; i < Sizeofinput; i++)
                {
                    l_TempArr[i] = io_input % 10;
                    io_input /= 10;
                }
                BinaryNumber l_Object = new BinaryNumber(l_TempArr);
                return l_Object;
            }
            string l_errorMsg = string.Format(@"invalid input, please enter 8 digits of either '1' or '0'");
            throw new Exception(l_errorMsg);

        }
        public void PrintBinary()
        {
            string l_Output = @" (";
            for (int i = m_BinaryNum.Length - 1; i >= 0; i--)
            {
               l_Output = string.Concat(l_Output ,m_BinaryNum[i].ToString());
            }
            l_Output = string.Concat(l_Output,") ");
            Console.Write(l_Output);
        }
        static void PrintBinaryNumber(int[,] i_Binary_Numbers, int row)
        {
            for (int i = 7; i >= 0; i--)
            {
                Console.Write(i_Binary_Numbers[row, i]);
            }
        }
        public void PrintNumericValue()
        {
            string l_numericOutput = GetNumericValue().ToString();
            l_numericOutput.Concat(" ");
            Console.Write(l_numericOutput);
        }

        public int GetShortestBitSequence()
        {
            int l_MinimumSequence = 8;
            int l_PrevioustDigit = GetBinaryDigit(0);
            int l_SequenceCounter = 1;
            for (int j = 1; j < 8; j++)
            {
                int l_CurrentBit = GetBinaryDigit(j);
                if (l_PrevioustDigit != l_CurrentBit)
                {
                    if (l_MinimumSequence > l_SequenceCounter)
                    {
                        l_MinimumSequence = l_SequenceCounter;
                    }
                    l_SequenceCounter = 1;
                    l_PrevioustDigit = l_CurrentBit;
                }
                else
                {
                    l_SequenceCounter++;
                }
            }
            if (l_MinimumSequence > l_SequenceCounter)
            {
                l_MinimumSequence = l_SequenceCounter;
            }
            return l_MinimumSequence;
        }
    }

   
    class main
    {
        static void Main()
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
                    catch  (Exception l_invalidinput)
                    {
                        Console.WriteLine(l_invalidinput.Message);
                    }
                }
            }
            utils.quickSort( l_BinaryNumberArray, 0, l_BinaryNumberArray.Length - 1);
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
            float l_BinaryNumbersAverage =  utils.Avg(l_BinaryNumberArray[0], l_BinaryNumberArray[1], l_BinaryNumberArray[2]);
            Console.WriteLine();
            Output = $@"Average: {l_BinaryNumbersAverage}";
            Console.WriteLine(Output);
            utils.FindShortestBitSequence(l_BinaryNumberArray);
        }
    }
}

