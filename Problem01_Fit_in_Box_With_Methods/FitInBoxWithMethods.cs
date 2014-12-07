using System;
class FitInBoxWithMethods
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

        CheckBiggerBox(firstBoxSide1, secondBoxSide1, firstBoxSide2, secondBoxSide2, firstBoxSide3, secondBoxSide3);
        CheckBiggerBox(firstBoxSide1, secondBoxSide1, firstBoxSide3, secondBoxSide2, firstBoxSide2, secondBoxSide3);
        CheckBiggerBox(firstBoxSide3, secondBoxSide1, firstBoxSide1, secondBoxSide2, firstBoxSide2, secondBoxSide3);
        CheckBiggerBox(firstBoxSide3, secondBoxSide1, firstBoxSide2, secondBoxSide2, firstBoxSide1, secondBoxSide3);
        CheckBiggerBox(firstBoxSide2, secondBoxSide1, firstBoxSide1, secondBoxSide2, firstBoxSide3, secondBoxSide3);
        CheckBiggerBox(firstBoxSide2, secondBoxSide1, firstBoxSide3, secondBoxSide2, firstBoxSide1, secondBoxSide3);
    }

    private static void CheckBiggerBox(int firstSide1, int secondSide1, int firstSide2,
                                        int secondSide2, int firstSide3, int secondSide3)
    {
        if (firstSide1 > secondSide1 && firstSide2 > secondSide2 && firstSide3 > secondSide3)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", secondSide1, secondSide2, secondSide3,
                firstSide1, firstSide2, firstSide3);
        }
    }
}
