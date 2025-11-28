using System;
using System.Text;
namespace Ex01_04
{
    class StringAnalayzer
    {
        private string m_InputStr;
        private long m_InputAsNumber;
        private string m_InputAsLetters;

        public StringAnalayzer()
        {
            m_InputStr = "";
        }
        public StringAnalayzer(string i_inputStr)
        {
            m_InputStr = i_inputStr;
            if (IsNumbersOnly() == true)
            {
                m_InputAsNumber = long.Parse(i_inputStr);
            }
            else if (IsLettersOnly())
            {
                m_InputAsLetters = m_InputStr;
            }
        }
        public static bool CheckIfLengthIs10(string i_inputStr)
        {
            return i_inputStr.Length == 10;
        }
        public static bool CheckUserInput(string i_numberStr)
        {
            return CheckIfLengthIs10(i_numberStr);
        }
        public static StringAnalayzer Parse(string i_inputStr)
        {
            StringAnalayzer l_StringAnalayzerObject;
            if (CheckUserInput(i_inputStr) == true)
            {
                l_StringAnalayzerObject = new StringAnalayzer(i_inputStr);
            }
            else
            {
                throw new Exception("Must Contain input Length of 10");
            }
            return l_StringAnalayzerObject;
        }

        public bool IsNumbersOnly()
        {
            long l_StrAsNumber;
            return long.TryParse(m_InputStr, out l_StrAsNumber);
        }
        public bool IsLettersOnly()
        {
            bool l_flag = true;
            for (int i = 0; i < 10; i++)
            {
                if (!('A' <= m_InputStr[i] && m_InputStr[i] <= 'Z') && !('a' <= m_InputStr[i] && m_InputStr[i] <= 'z'))
                {
                    l_flag = false;
                }
            }
            return l_flag;
        }

        public void PrintIsDevidedBy3()
        {
            StringBuilder l_Builder = new StringBuilder();
            l_Builder.Append($@"Is Number Devided By 3? : ");
            if (m_InputAsNumber % 3 == 0)
            {
                l_Builder.Append(@"yes");
            }
            else
            {
                l_Builder.Append(@"no ");
            }
            Console.WriteLine(l_Builder.ToString());
        }

        public void PrintHowManyUpperCase()
        {
            int l_CounterUpperCase = 0;
            for (int i = 0; i < 10; i++)
            {
                if ('A' <= m_InputAsLetters[i] && m_InputAsLetters[i] <= 'Z')
                {
                    l_CounterUpperCase++;
                }
            }
            string l_output = $@"Number Of UpperCase Letters: {l_CounterUpperCase}";
            Console.WriteLine(l_output);
        }
        public void PrintHowManyLowerCase()
        {
            int l_CounterLowerCase = 0;
            for (int i = 0; i < 10; i++)
            {
                if ('a' <= m_InputAsLetters[i] && m_InputAsLetters[i] <= 'z')
                {
                    l_CounterLowerCase++;
                }
            }
            string l_output = $@"Number Of LowerCase Letters: {l_CounterLowerCase}";
            Console.WriteLine(l_output);
        }
        public void PrintIsInAlphabeticalOrder()
        {
            string l_inputAsUpperCase = m_InputAsLetters.ToUpper();
            char l_PreviousLetter = l_inputAsUpperCase[0];
            bool l_Flag = true;
            for (int i = 0; i < 10; i++)
            {
                if (!(l_PreviousLetter <= l_inputAsUpperCase[i]))
                {
                    l_Flag = false;
                }
                else
                {
                    l_PreviousLetter = l_inputAsUpperCase[i];
                }
            }

            StringBuilder l_builder = new StringBuilder();
            l_builder.Append(@"Is It in Alphabetical Order: ");
            if (l_Flag == true)
            {
                l_builder.Append(@" yes");
            }
            else
            {
                l_builder.Append(@" no");
            }
            Console.WriteLine(l_builder.ToString());
        }

        public bool IsPalindrome(int i, int j)
        {
            bool l_result;
            if (i <= j)
            {
                if (m_InputStr[i] == m_InputStr[j])
                {
                    l_result = IsPalindrome(i + 1, j - 1);
                }
                else
                {
                    l_result = false;
                }
            }
            else
            {
                l_result = true;
            }
            return l_result;
        }
        public void PrintIsPalindrome()
        {
            bool l_result = IsPalindrome(0, 9);
            StringBuilder l_Builder = new StringBuilder();
            l_Builder.Append(@"Is Number Palindrome: ");
            if (l_result == true)
            {
                l_Builder.Append(@" yes ");
            }
            else
            {
                l_Builder.Append(@" No");
            }
            Console.WriteLine(l_Builder.ToString());
        }
    }
}
