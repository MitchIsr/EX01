using System;


namespace Ex01_02
{
    public class NumbersTree
    {
        public int m_TotalTreeHeight;

        public NumbersTree(int i_TotalTreeHeight = 7)
        {
            m_TotalTreeHeight = i_TotalTreeHeight;
        }

        public void Print()
        {
            const int k_TrunkHeight = 2;
            int l_LeavesHeight = m_TotalTreeHeight - k_TrunkHeight;
            int l_CurrentNumber = 1;

            //  Print the leaves:
            for (int l_CurrentTreeRow = 0; l_CurrentTreeRow < l_LeavesHeight; l_CurrentTreeRow++)
            {
                char l_rowLetter = (char)('A' + l_CurrentTreeRow);
                Console.Write(l_rowLetter + " ");

                int l_NumbersInRow = 2 * l_CurrentTreeRow + 1;
                int l_SpacesBefore = (l_LeavesHeight - 1 - l_CurrentTreeRow) * 2;

                Console.Write(new string(' ', l_SpacesBefore));

                for (int i = 0; i < l_NumbersInRow; i++)
                {
                    Console.Write(l_CurrentNumber);
                    Console.Write(' ');

                    if (i == l_NumbersInRow - 1)
                    {
                        Console.WriteLine();
                    }

                    l_CurrentNumber++;
                    if (l_CurrentNumber > 9)
                    {
                        l_CurrentNumber = 1;
                    }
                }
            }

            // Print the trunk:
            int l_trunkSpaces = 2 * l_LeavesHeight - 3;

            for (int l_CurrentTrunkRow = 0; l_CurrentTrunkRow < k_TrunkHeight; l_CurrentTrunkRow++)
            {
                int l_rowIndex = l_LeavesHeight + l_CurrentTrunkRow;
                char l_rowLetter = (char)('A' + l_rowIndex);

                Console.Write(l_rowLetter + " ");
                Console.Write(new string(' ', l_trunkSpaces));
                Console.WriteLine("|" + l_CurrentNumber + "|");
            }
        }
    }
}
