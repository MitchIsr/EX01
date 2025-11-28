using System;
using System.Text;

namespace Ex01_04
{
    public class StringAnalayzerProgram
    {
        public static void StartProgram()
        {
            string l_Output = @"Hello, Welcome to Ex01_04 String Analayzer
Please Enter any input With a length of 10: ";
            Console.WriteLine(l_Output);

            StringAnalayzer l_StrInput = new StringAnalayzer();
            bool v_isInputValid = false;

            while (v_isInputValid == false)
            {
                string l_input = Console.ReadLine();
                try
                {
                    l_StrInput = StringAnalayzer.Parse(l_input);
                    v_isInputValid = true;
                }
                catch (Exception l_invalidinput)
                {
                    Console.WriteLine(l_invalidinput.Message);
                }
            }

            l_StrInput.PrintIsPalindrome();

            if (l_StrInput.IsNumbersOnly() == true)
            {
                l_StrInput.PrintIsDevidedBy3();
            }
            else if (l_StrInput.IsLettersOnly() == true) 
            {
                l_StrInput.PrintHowManyUpperCase();
                l_StrInput.PrintHowManyLowerCase();
                l_StrInput.PrintIsInAlphabeticalOrder();
            }

        }
    }
}
