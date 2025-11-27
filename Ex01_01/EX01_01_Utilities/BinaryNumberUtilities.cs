using System;
using Ex01_01;
namespace Ex01_01_Utilities
{
   public class utils
   {
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

            for (int i = 0; i < 3; i++)
            {
                if (l_LengthOfBitSequenceBinNumberArray[i] == l_MinimumSequence)
                {
                    i_BinaryNumbersArray[i].PrintBinary();
                    if (i < 2)
                    {
                        Console.Write(", ");
                    }
                }

            }


        }
    }
}