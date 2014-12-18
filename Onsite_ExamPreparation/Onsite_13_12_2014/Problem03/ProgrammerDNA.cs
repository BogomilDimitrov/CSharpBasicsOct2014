using System;
class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int rowLenght = int.Parse(Console.ReadLine());
        char startingLetter = (char)Console.Read();

        int dots = rowLenght/2;
        int dotMultiplier = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', dots));
            for (int j = 0; j < rowLenght-2*dots; j++)
            {
                Console.Write(startingLetter);
                startingLetter++;
                if (startingLetter == 'H')
                    startingLetter = 'A';
            }
            Console.WriteLine(new string('.', dots));
            dots -= dotMultiplier;
            if (dots == -1)
            {
                dots = 1;
                dotMultiplier *= -1;
            }
            else if (dots == rowLenght/2 + 1)
            {
                dots = rowLenght/2;
                dotMultiplier *= -1;
            }
        }
    }
}