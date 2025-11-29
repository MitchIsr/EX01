using System;
using Ex01_02;

namespace Ex01_03
{
    public static class DynamicNumbersTree
    {
        public static NumbersTree CreateNumberTree()
        {
            string l_msg = string.Format(@"Please enter the height you whishes for the Number Tree (minimum is 4 , maximum is 15): ");
            Console.WriteLine(l_msg);

            while (true)
            {
                string i_userInputStr = Console.ReadLine();
                bool l_IsValidNumber = int.TryParse(i_userInputStr, out int i_TreeHeight);

                if (l_IsValidNumber == true && i_TreeHeight >= 4 && i_TreeHeight <= 15)
                {
                    NumbersTree o_NumbersTree = new NumbersTree(i_TreeHeight);
                    return o_NumbersTree;
                }
                else
                {
                    string output = @"Invalid input! Please enter a valid number between 4 and 15: ";
                    Console.WriteLine(output);
                }
            }
        }

        static public void Print(NumbersTree i_NumbersTree)
        {
            i_NumbersTree.Print();
        }
    }
}
