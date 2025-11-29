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
            int lo_containDigitsOnly;
            return CheckIfLengthIs7(i_numberStr) && int.TryParse(i_numberStr, out lo_containDigitsOnly);
        }

        public static NumberStatistics Parse(string i_numberStr)
        {
            NumberStatistics o_numberStatisticsObject;
            if (CheckUserInput(i_numberStr) == true)
            {
                o_numberStatisticsObject = new NumberStatistics(i_numberStr);
            }
            else
            {
                throw new Exception("Must Contain Digits with Length of 7 , Numbers Cannot start with 0");
            }
            return o_numberStatisticsObject;
        }

        public int GetDigit(int i_Index)
        {
            return int.Parse(m_Number[i_Index].ToString());
        }
        public void PrintCountDigitsBiggerThanFirstDigit()
        {
            int o_biggerDigitsCounter = 0;
            int o_firstDigit = GetDigit(0);
            for (int i = 1; i < 7; i++)
            {
                if (GetDigit(i) > o_firstDigit)
                {
                    o_biggerDigitsCounter++;
                }
            }
            string output = $@"First left Digit: {o_firstDigit}. Digits Bigger Than it: {o_biggerDigitsCounter}";
            Console.WriteLine(output);
 
        }


        public void PrintHowManyDigitsDevidedBy3Counter()
        {
            int o_digitsDevideableBy3Counter = 0;
            for(int i = 0; i<7;i++)
            {
                if (GetDigit(i) % 3 == 0)
                    o_digitsDevideableBy3Counter++;
            }
            string output = $@"How Many Numbers Devided By 3? {o_digitsDevideableBy3Counter} ";
            Console.WriteLine(output);
        }

        public void PrintDifferenceBetweenMaxDigitAndMinDigit()
        {
            int o_min = 9, o_max = 0;
            for (int i = 0; i < 7; i++)
            {
                int l_currentDigit = GetDigit(i);
                if(l_currentDigit>o_max)
                {
                    o_max = l_currentDigit;
                }
                if (l_currentDigit < o_min)
                {
                    o_min = l_currentDigit;
                }
            }
            string output = $@"Difference Between Biggest Digit and Smallest: {(o_max - o_min)}";
            Console.WriteLine(output);

        }
        public void PrintMostCommonDigit()
        {
            int o_maxAppearanceCounter = 0;
            int o_maxAppearanceDigit= -1;
            for(int i=0; i<7; i++)
            {
                int l_currentDigit = GetDigit(i);
                int l_currentDigitCounter = 0;

                for (int j = 0; j < 7; j++)
                {
                    if (GetDigit(j) == l_currentDigit)
                        l_currentDigitCounter++;
                }
                if(l_currentDigitCounter> o_maxAppearanceCounter)
                {
                    o_maxAppearanceCounter = l_currentDigitCounter;
                    o_maxAppearanceDigit = l_currentDigit;
                }
            }
            string output = $@"Most Common Digit: {o_maxAppearanceDigit} (Shows up {o_maxAppearanceCounter} times) ";
            Console.WriteLine(output);
        }
              
   
    }




}


