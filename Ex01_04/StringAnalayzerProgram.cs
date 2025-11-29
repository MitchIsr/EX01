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

            StringAnalayzer i_strInput = new StringAnalayzer();
            bool isInputValid = false;

            while (isInputValid == false)
            {
                string l_input = Console.ReadLine();
                try
                {
                    i_strInput = StringAnalayzer.Parse(l_input);
                    isInputValid = true;
                }
                catch (Exception l_invalidinput)
                {
                    Console.WriteLine(l_invalidinput.Message);
                }
            }

            i_strInput.PrintIsPalindrome();

            if (i_strInput.IsNumbersOnly() == true)
            {
                i_strInput.PrintIsDevidedBy3();
            }
            else if (i_strInput.IsLettersOnly() == true) 
            {
                i_strInput.PrintHowManyUpperCase();
                i_strInput.PrintHowManyLowerCase();
                i_strInput.PrintIsInAlphabeticalOrder();
            }

        }
    }
}
