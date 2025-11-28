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
                char rowLetter = (char)('A' + l_CurrentTreeRow);
                Console.Write(rowLetter + " ");

                int numbersInRow = 2 * l_CurrentTreeRow + 1;
                int spacesBefore = (l_LeavesHeight - 1 - l_CurrentTreeRow) * 2;

                Console.Write(new string(' ', spacesBefore));

                for (int i = 0; i < numbersInRow; i++)
                {
                    Console.Write(l_CurrentNumber);
                    Console.Write(' ');

                    if (i == numbersInRow - 1)
                    {
                        Console.Write("\n");
                    }

                    l_CurrentNumber++;
                    if (l_CurrentNumber > 9)
                    {
                        l_CurrentNumber = 1;
                    }
                }
            }

            // Print the trunk:
            int trunkSpaces = 2 * l_LeavesHeight - 3;

            for (int l_CurrentTrunkRow = 0; l_CurrentTrunkRow < k_TrunkHeight; l_CurrentTrunkRow++)
            {
                int rowIndex = l_LeavesHeight + l_CurrentTrunkRow;
                char rowLetter = (char)('A' + rowIndex);

                Console.Write(rowLetter + " ");
                Console.Write(new string(' ', trunkSpaces));
                Console.WriteLine("|" + l_CurrentNumber + "|");
            }
        }
    }
}
