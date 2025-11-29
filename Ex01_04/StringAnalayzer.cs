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
        public static bool CheckIfLengthIs10(string io_inputStr)
        {
            return io_inputStr.Length == 10;
        }
        public static bool CheckUserInput(string io_numberStr)
        {
            return CheckIfLengthIs10(io_numberStr);
        }
        public static StringAnalayzer Parse(string io_inputStr)
        {
            StringAnalayzer o_stringAnalayzerObject;
            if (CheckUserInput(io_inputStr) == true)
            {
                o_stringAnalayzerObject = new StringAnalayzer(io_inputStr);
            }
            else
            {
                throw new Exception("Must Contain input Length of 10");
            }
            return o_stringAnalayzerObject;
        }

        public bool IsNumbersOnly()
        {
            long o_strAsNumber;
            return long.TryParse(m_InputStr, out o_strAsNumber);
        }
        public bool IsLettersOnly()
        {
            bool o_flag = true;
            for (int i = 0; i < 10; i++)
            {
                if (!('A' <= m_InputStr[i] && m_InputStr[i] <= 'Z') && !('a' <= m_InputStr[i] && m_InputStr[i] <= 'z'))
                {
                    o_flag = false;
                }
            }
            return o_flag;
        }

        public void PrintIsDevidedBy3()
        {
            StringBuilder l_builder = new StringBuilder();
            l_builder.Append($@"Is Number Devided By 3? : ");
            if (m_InputAsNumber % 3 == 0)
            {
                l_builder.Append(@"yes");
            }
            else
            {
                l_builder.Append(@"no ");
            }
            Console.WriteLine(l_builder.ToString());
        }

        public void PrintHowManyUpperCase()
        {
            int o_counterUpperCase = 0;
            for (int i = 0; i < 10; i++)
            {
                if ('A' <= m_InputAsLetters[i] && m_InputAsLetters[i] <= 'Z')
                {
                    o_counterUpperCase++;
                }
            }
            string output = $@"Number Of UpperCase Letters: {o_counterUpperCase}";
            Console.WriteLine(output);
        }
        public void PrintHowManyLowerCase()
        {
            int o_counterLowerCase = 0;
            for (int i = 0; i < 10; i++)
            {
                if ('a' <= m_InputAsLetters[i] && m_InputAsLetters[i] <= 'z')
                {
                    o_counterLowerCase++;
                }
            }
            string output = $@"Number Of LowerCase Letters: {o_counterLowerCase}";
            Console.WriteLine(output);
        }
        public void PrintIsInAlphabeticalOrder()
        {
            string l_inputAsUpperCase = m_InputAsLetters.ToUpper();
            char l_previousLetter = l_inputAsUpperCase[0];
            bool l_flag = true;
            for (int i = 0; i < 10; i++)
            {
                if (!(l_previousLetter <= l_inputAsUpperCase[i]))
                {
                    l_flag = false;
                }
                else
                {
                    l_previousLetter = l_inputAsUpperCase[i];
                }
            }

            StringBuilder p_builder = new StringBuilder();
            p_builder.Append(@"Is It in Alphabetical Order: ");
            if (l_flag == true)
            {
                p_builder.Append(@" yes");
            }
            else
            {
                p_builder.Append(@" no");
            }
            Console.WriteLine(p_builder.ToString());
        }

        public bool IsPalindrome(int i, int j)
        {
            bool o_result;
            if (i <= j)
            {
                if (m_InputStr[i] == m_InputStr[j])
                {
                    o_result = IsPalindrome(i + 1, j - 1);
                }
                else
                {
                    o_result = false;
                }
            }
            else
            {
                o_result = true;
            }
            return o_result;
        }
        public void PrintIsPalindrome()
        {
            bool l_result = IsPalindrome(0, 9);
            StringBuilder o_builder = new StringBuilder();
            o_builder.Append(@"Is Number Palindrome: ");
            if (l_result == true)
            {
                o_builder.Append(@" yes ");
            }
            else
            {
                o_builder.Append(@" No");
            }
            Console.WriteLine(o_builder.ToString());
        }
    }
}
