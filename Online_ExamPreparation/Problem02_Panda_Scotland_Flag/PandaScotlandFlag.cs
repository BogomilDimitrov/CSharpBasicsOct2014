using System;
class PandaScotlandFlag
{
    static void Main()
    {
        char currChar = 'A';
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n/2-1; i++) 
        {
            Console.Write(new string('~', i));
            if (currChar == 'Z' + 1) // '['
                currChar = 'A';
            Console.Write(currChar++);
            Console.Write(new string('#', n - 2 - 2 * i));
            if (currChar == 'Z' + 1)
                currChar = 'A';
            Console.Write(currChar++);
            Console.WriteLine(new string('~', i));
        }

        Console.Write(new string('-', n/2));
        if (currChar == 'Z' + 1) // '['
            currChar = 'A';
        Console.Write(currChar++);
        Console.WriteLine(new string('-', n / 2));

        for (int i = n/2-1; i >= 0; i--)
        {
            Console.Write(new string('~', i));
            if (currChar == 'Z' + 1) // '['
                currChar = 'A';
            Console.Write(currChar++);
            Console.Write(new string('#', n - 2 - 2 * i));
            if (currChar == 'Z' + 1)
                currChar = 'A';
            Console.Write(currChar++);
            Console.WriteLine(new string('~', i));
        }

    }
}

