using System;
class MorseCodeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()); //1234
        int nSum = 0;
        bool hasAnwer = false;

        while (n != 0)
        {
            //Getting the current digit of the number
            int remainder = n % 10;
            //Summing up the digit to the total sum
            nSum += remainder;
            //Removing the last digit from the number
            n /= 10;
        }

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                for (int k = 1; k <= 5; k++)
                {
                    for (int l = 1; l <= 5; l++)
                    {
                        for (int m = 1; m <= 5; m++)
                        {
                            for (int o = 1; o <= 5; o++)
                            {
                                int product = i * j * k * l * m * o;
                                if (product == nSum)
                                {
                                    Console.WriteLine(GetMorseCodeByNumber(i) + '|' +
                                                        GetMorseCodeByNumber(j) + '|' +
                                                        GetMorseCodeByNumber(k) + '|' +
                                                        GetMorseCodeByNumber(l) + '|' +
                                                        GetMorseCodeByNumber(m) + '|' +
                                                        GetMorseCodeByNumber(o) + '|');
                                    hasAnwer = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        if (hasAnwer != true)
            Console.WriteLine("No");

    }

    static string GetMorseCodeByNumber(int num)
    {
        switch (num)
        {
            case 1:
                return ".----";
            case 2:
                return "..---";
            case 3:
                return "...--";
            case 4:
                return "....-";
            case 5:
                return ".....";
            default:
                return "";
        }
    }
}

