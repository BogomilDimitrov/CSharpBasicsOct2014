using System;
class BitPathsMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] bitMatrix = new char[8, 4];
        for (int i = 0; i < bitMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < bitMatrix.GetLength(1); j++)
            {
                bitMatrix[i, j] = '0';
            }
        }

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');
            int col = int.Parse(numbers[0]); //starting Col

            ChangeBitValue(bitMatrix, 0, col);

            for (int j = 1; j < bitMatrix.GetLength(0); j++)
            {
                col += int.Parse(numbers[j]);
                ChangeBitValue(bitMatrix, j, col);
            }
        }

        int sum = 0;

        for (int i = 0; i < bitMatrix.GetLength(0); i++)
        {
            string currentBitwiseNumber = "";
            for (int j = 0; j < bitMatrix.GetLength(1); j++)
            {
                currentBitwiseNumber += bitMatrix[i, j];
            }
            sum += Convert.ToInt32(currentBitwiseNumber,2);
        }
        Console.WriteLine(Convert.ToString(sum, 2));
        Console.WriteLine("{0:X}", sum);
    }

    private static void ChangeBitValue(char[,] bitMatrix, int row, int col)
    {
        if (bitMatrix[row, col] == '0')
            bitMatrix[row, col] = '1';
        else
            bitMatrix[row, col] = '0';
    }
}
