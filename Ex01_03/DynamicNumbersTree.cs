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
                string l_UserInputStr = Console.ReadLine();
                bool l_isValidNumber = int.TryParse(l_UserInputStr, out int l_TreeHeight);
                if (l_isValidNumber && l_TreeHeight >= 4 && l_TreeHeight <= 15)
                {
                    NumbersTree o_NumbersTree = new NumbersTree(l_TreeHeight);
                    return o_NumbersTree;
                }
                else
                {
                    string l_Output = @"Invalid input! Please enter a valid number between 4 and 15: ";
                    Console.WriteLine(l_Output);
                }
            }
        }

        static public void Print(NumbersTree i_NumbersTree)
        {
            i_NumbersTree.Print();
        }
    }
}
