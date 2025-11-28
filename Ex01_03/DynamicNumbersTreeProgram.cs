using Ex01_02;
using System;


namespace Ex01_03
{
    public class DynamicNumbersTreeProgram
    {
        public static void StartProgram()
        {
            NumbersTree InputNumbersTree = DynamicNumbersTree.CreateNumberTree();
            DynamicNumbersTree.Print(InputNumbersTree);
        }
    }
}
