/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

using static System.Console;
Clear();

int GetintFromConsole(string message)
{
    Write(message);
    return int.Parse(ReadLine()!);
}

int[,] GetSpirilMatrix(int rows)
{
    int[,] array = new int[rows, rows];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= rows * rows)
    {
        array[i, j] = temp;
        if (i <= j + 1 && i + j < rows - 1) j++;
        else if (i < j && i + j >= rows - 1) i++;
        else if (i >= j && i + j > rows - 1) j--;
        else i--;
        temp++;
    }
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            Write($"{array[x, y]}\t");
        }
        WriteLine();
    }
    return array;
}

int[,] matrix = GetSpirilMatrix(GetintFromConsole("Enter number of rows = "));