using System;

class BitShooter
{
    static void Main()
    {
        long number = (long)UInt64.Parse(Console.ReadLine());
        int leftCount = 0;
        int rightCount = 0;

        for (int i = 0; i < 3; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            int size = Int32.Parse(line[1]);//5
            int startingBit = Int32.Parse(line[0]);//1
            int endBit = startingBit + size / 2;
            startingBit -= size / 2;
            if (startingBit < 0)
            {
                startingBit = 0; // 0
            }
            if (endBit > 63)
            {
                endBit = 63;
            }
            for (int j = startingBit; j <= endBit; j++)
            {
                short currentBit = (short)(number >> j & 1);
                if (currentBit == 1)
                {
                    number = number & ~((long)1 << j);
                }
            }
        }

        for (int i = 0; i <= 63; i++)
        {
            if (i < 32)
            {
                short currentBit = (short)(number >> i & 1);
                if (currentBit == 1)
                {
                    rightCount++;
                }
            }
            else
            {
                short currentBit = (short)(number >> i & 1);
                if (currentBit == 1)
                {
                    leftCount++;
                }
            }
        }

        Console.WriteLine("left: " + leftCount);
        Console.WriteLine("right: " + rightCount);
    }


}