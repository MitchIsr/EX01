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
            const int k_trunkHeight = 2;
            int l_leavesHeight = m_TotalTreeHeight - k_trunkHeight;
            int l_currentNumber = 1;

            //  Print the leaves:
            for (int l_currentTreeRow = 0; l_currentTreeRow < l_leavesHeight; l_currentTreeRow++)
            {
                char l_rowLetter = (char)('A' + l_currentTreeRow);
                Console.Write(l_rowLetter + " ");

                int l_numbersInRow = 2 * l_currentTreeRow + 1;
                int l_spacesBefore = (l_leavesHeight - 1 - l_currentTreeRow) * 2;

                Console.Write(new string(' ', l_spacesBefore));

                for (int i = 0; i < l_numbersInRow; i++)
                {
                    Console.Write(l_currentNumber);
                    Console.Write(' ');

                    if (i == l_numbersInRow - 1)
                    {
                        Console.WriteLine();
                    }

                    l_currentNumber++;
                    if (l_currentNumber > 9)
                    {
                        l_currentNumber = 1;
                    }
                }
            }

            // Print the trunk:
            int l_trunkSpaces = 2 * l_leavesHeight - 3;

            for (int l_currentTrunkRow = 0; l_currentTrunkRow < k_trunkHeight; l_currentTrunkRow++)
            {
                int l_rowIndex = l_leavesHeight + l_currentTrunkRow;
                char l_rowLetter = (char)('A' + l_rowIndex);

                Console.Write(l_rowLetter + " ");
                Console.Write(new string(' ', l_trunkSpaces));
                Console.WriteLine("|" + l_currentNumber + "|");
            }
        }
    }
}
