using System;

namespace NumberStats
{
    class NumberStatistics
    {
        private string m_Number;

        public NumberStatistics(string i_number)
        {
            m_Number = i_number;
        }
        public NumberStatistics()
        {
            m_Number = "";
        }

        public static bool CheckIfLengthIs7(string i_numberStr)
        {
            return i_numberStr.Length == 7;
        }
        public static bool CheckUserInput(string i_numberStr)
        {
            int l_ContainDigitsOnly;
            return CheckIfLengthIs7(i_numberStr) && int.TryParse(i_numberStr, out l_ContainDigitsOnly);
        }

        public static NumberStatistics Parse(string i_numberStr)
        {
            NumberStatistics l_NumberStatisticsObject;
            if (CheckUserInput(i_numberStr) == true)
            {
                l_NumberStatisticsObject = new NumberStatistics(i_numberStr);
            }
            else
            {
                throw new Exception("Must Contain Digits with Length of 7 , Numbers Cannot start with 0");
            }
            return l_NumberStatisticsObject;
        }

        public int GetDigit(int i_Index)
        {
            return int.Parse(m_Number[i_Index].ToString());
        }
        public void PrintCountDigitsBiggerThanFirstDigit()
        {
            int l_BiggerDigitsCounter = 0;
            int l_FirstDigit = GetDigit(0);
            for (int i = 1; i < 7; i++)
            {
                if (GetDigit(i) > l_FirstDigit)
                {
                    l_BiggerDigitsCounter++;
                }
            }
            string l_output = $@"First left Digit: {l_FirstDigit}. Digits Bigger Than it: {l_BiggerDigitsCounter}";
            Console.WriteLine(l_output);
 
        }


        public void PrintHowManyDigitsDevidedBy3Counter()
        {
            int l_DigitsDevideableBy3Counter = 0;
            for(int i = 0; i<7;i++)
            {
                if (GetDigit(i) % 3 == 0)
                    l_DigitsDevideableBy3Counter++;
            }
            string l_output = $@"How Many Numbers Devided By 3? {l_DigitsDevideableBy3Counter} ";
            Console.WriteLine(l_output);
        }

        public void PrintDifferenceBetweenMaxDigitAndMinDigit()
        {
            int l_Min = 9, l_Max = 0;
            for (int i = 0; i < 7; i++)
            {
                int l_CurrentDigit = GetDigit(i);
                if(l_CurrentDigit>l_Max)
                {
                    l_Max = l_CurrentDigit;
                }
                if (l_CurrentDigit < l_Min)
                {
                    l_Min = l_CurrentDigit;
                }
            }
            string l_output = $@"Difference Between Biggest Digit and Smallest: {(l_Max - l_Min)}";
            Console.WriteLine(l_output);

        }
        public void PrintMostCommonDigit()
        {
            int l_MaxAppearanceCounter = 0;
            int l_MaxAppearanceDigit= -1;
            for(int i=0; i<7; i++)
            {
                int l_CurrentDigit = GetDigit(i);
                int l_CurrentDigitCounter = 0;

                for (int j = 0; j < 7; j++)
                {
                    if (GetDigit(j) == l_CurrentDigit)
                        l_CurrentDigitCounter++;
                }
                if(l_CurrentDigitCounter> l_MaxAppearanceCounter)
                {
                    l_MaxAppearanceCounter = l_CurrentDigitCounter;
                    l_MaxAppearanceDigit = l_CurrentDigit;
                }
            }
            string l_output = $@"Most Common Digit: {l_MaxAppearanceDigit} (Shows up {l_MaxAppearanceCounter} times) ";
            Console.WriteLine(l_output);
        }
              
   
    }




}


