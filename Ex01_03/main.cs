using System;
using Ex01_02;

namespace Ex01_03
{
    internal class main
    {
        public static void Main()
        {
            NumbersTree InputNumbersTree = DynamicNumbersTree.CreateNumberTree();
            DynamicNumbersTree.Print(InputNumbersTree);
        }
    }
}
