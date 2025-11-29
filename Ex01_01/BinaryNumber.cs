using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            m_NumericValue = GetBinaryInBase10();
        }

        public int GetBinaryDigit(int Index)
        {
            return this.m_BinaryNum[Index];
        }

        public int GetNumericValue()
        {
            return m_NumericValue;
        }
        public static bool IsLengthEquals8(string i_BinaryNumberstr)
        {
            return i_BinaryNumberstr.Length == 8;
        }

        public static bool IsContainDigit1And0(string i_BinaryNumberStr)
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
        public int GetBinaryInBase10()
        {
            int l_sumOfBinaryInNumeric = 0;
            for (int i = 0, l_currentIndexRep = 1; i < 8; i++, l_currentIndexRep *= 2)
            {
                l_sumOfBinaryInNumeric += (l_currentIndexRep * m_BinaryNum[i]);
            }
            return l_sumOfBinaryInNumeric;
        }



        public static bool CheckUserInput(string i_binaryNumberStr)
        {
            return IsContainDigit1And0(i_binaryNumberStr) && IsLengthEquals8(i_binaryNumberStr);
        }

        public BinaryNumber Parse(string i_BinaryNumberStr)
        {
            int l_sizeOfInput = i_BinaryNumberStr.Length;

            bool l_isUserinputValid = CheckUserInput(i_BinaryNumberStr);
            if (l_isUserinputValid == true)
            {
                int o_input = int.Parse(i_BinaryNumberStr);
                int[] io_tempArr = new int[8];
                for (int i = 0; i < l_sizeOfInput; i++)
                {
                    io_tempArr[i] = o_input % 10;
                    o_input /= 10;
                }
                BinaryNumber o_object = new BinaryNumber(io_tempArr);
                return o_object;
            }
            string l_errorMsg = string.Format(@"invalid input, please enter 8 digits of either '1' or '0'");
            throw new Exception(l_errorMsg);

        }
        public void PrintBinary()
        {
            string l_output = @" (";
            StringBuilder o_builder = new StringBuilder();
            o_builder.Append(l_output);
            for (int i = m_BinaryNum.Length - 1; i >= 0; i--)
            {
                o_builder.Append(m_BinaryNum[i].ToString());
            }
            o_builder.Append( ") ");
            Console.Write(o_builder.ToString());

        }

        public void PrintNumericValue()
        {
            string o_numericOutput = GetNumericValue().ToString();
            Console.Write(o_numericOutput+" ");
        }

        public int GetShortestBitSequence()
        {
            int o_minimumSequence = 8;
            int l_previoustDigit = GetBinaryDigit(0);
            int l_sequenceCounter = 1;
            for (int j = 1; j < 8; j++)
            {
                int l_currentBit = GetBinaryDigit(j);
                if (l_previoustDigit != l_currentBit)
                {
                    if (o_minimumSequence > l_sequenceCounter)
                    {
                        o_minimumSequence = l_sequenceCounter;
                    }
                    l_sequenceCounter = 1;
                    l_previoustDigit = l_currentBit;
                }
                else
                {
                    l_sequenceCounter++;
                }
            }
            if (o_minimumSequence > l_sequenceCounter)
            {
                o_minimumSequence = l_sequenceCounter;
            }
            return o_minimumSequence;
        }

        public bool IsPalindrome()
        {
            bool l_isDigitsEqualOrNot = true;
            for (int i = 0, j = 7; i < 4; i++, j--)
            {
                l_isDigitsEqualOrNot = !(GetBinaryDigit(i) != GetBinaryDigit(j));
            }
            return l_isDigitsEqualOrNot;
        }

        public int Get1sAnd0sDifference()
        {
            int io_1sCounter = 0;
            int io_0sCounter = 0;
            for (int i = 0; i < 8; i++)
            {
                if (GetBinaryDigit(i) == 1)
                {
                    io_1sCounter++;
                }
                else
                {
                    io_0sCounter++;
                }

            }

            return BinaryNumberUtilities.Absolute(io_1sCounter, io_0sCounter);
        }
        public bool IsStartAndEndWithSameDigit()
        {
            return GetBinaryDigit(0) == GetBinaryDigit(7);
        }
    }


}


