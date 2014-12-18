using System;
class FitInBox
{
    static void Main()
    {
        int firstBoxSide1 = int.Parse(Console.ReadLine());
        int firstBoxSide2 = int.Parse(Console.ReadLine());
        int firstBoxSide3 = int.Parse(Console.ReadLine());
        int secondBoxSide1 = int.Parse(Console.ReadLine());
        int secondBoxSide2 = int.Parse(Console.ReadLine());
        int secondBoxSide3 = int.Parse(Console.ReadLine());

        //TRUE if firstBox is bigger than the second.
        //FALSE if secondBox is begger than the first.
        bool fBigger = Math.Max(firstBoxSide3, Math.Max(firstBoxSide1, firstBoxSide2)) >
                           Math.Max(secondBoxSide3, Math.Max(secondBoxSide1, secondBoxSide2));

        //Making the firstBox to be always bigger than the second.
        if (!fBigger)
        {
            secondBoxSide1 = secondBoxSide1 + firstBoxSide1;
            firstBoxSide1 = secondBoxSide1 - firstBoxSide1;
            secondBoxSide1 = secondBoxSide1 - firstBoxSide1;

            secondBoxSide2 = secondBoxSide2 + firstBoxSide2;
            firstBoxSide2 = secondBoxSide2 - firstBoxSide2;
            secondBoxSide2 = secondBoxSide2 - firstBoxSide2;

            secondBoxSide3 = secondBoxSide3 + firstBoxSide3;
            firstBoxSide3 = secondBoxSide3 - firstBoxSide3;
            secondBoxSide3 = secondBoxSide3 - firstBoxSide3;
        }
        
        if (firstBoxSide1 > secondBoxSide1 &&  //1 2 3 > 1 2 3
            firstBoxSide2 > secondBoxSide2 &&
            firstBoxSide3 > secondBoxSide3)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", secondBoxSide1, secondBoxSide2, secondBoxSide3, firstBoxSide1, firstBoxSide2, firstBoxSide3);
        }
        if (firstBoxSide1 > secondBoxSide1 && // 1 3 2 > 1 2 3
                firstBoxSide3 > secondBoxSide2 &&
                firstBoxSide2 > secondBoxSide3)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", secondBoxSide1, secondBoxSide2, secondBoxSide3, firstBoxSide1, firstBoxSide3, firstBoxSide2);
        }
        if (firstBoxSide2 > secondBoxSide1 && // 2 1 3 > 1 2 3
                 firstBoxSide1 > secondBoxSide2 &&
                 firstBoxSide3 > secondBoxSide3)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", secondBoxSide1, secondBoxSide2, secondBoxSide3, firstBoxSide2, firstBoxSide1, firstBoxSide3);
        }
        if (firstBoxSide2 > secondBoxSide1 && // 2 3 1 > 1 2 3
                 firstBoxSide3 > secondBoxSide2 &&
                 firstBoxSide1 > secondBoxSide3)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", secondBoxSide1, secondBoxSide2, secondBoxSide3, firstBoxSide2, firstBoxSide3, firstBoxSide1);
        }
        if (firstBoxSide3 > secondBoxSide1 && // 3 1 2 > 1 2 3
                 firstBoxSide1 > secondBoxSide2 &&
                 firstBoxSide2 > secondBoxSide3)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", secondBoxSide1, secondBoxSide2, secondBoxSide3, firstBoxSide3, firstBoxSide1, firstBoxSide2);
        }
        if (firstBoxSide3 > secondBoxSide1 && // 3 2 1 > 1 2 3
                 firstBoxSide2 > secondBoxSide2 &&
                 firstBoxSide1 > secondBoxSide3)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", secondBoxSide1, secondBoxSide2, secondBoxSide3, firstBoxSide3, firstBoxSide2, firstBoxSide1);
        }
    }
}
