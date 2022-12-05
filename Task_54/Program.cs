/*  Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

using static System.Console;
Clear();

int GetintFromConsole(string message)
{
    Write(message);
    return int.Parse(ReadLine()!);
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}\t");
        }
        WriteLine();
    }
}

void SortRowsInArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = j + 1; k < inArray.GetLength(1); k++)
            {
                if (inArray[i, j] < inArray[i, k])
                    (inArray[i, j], inArray[i, k]) = (inArray[i, k], inArray[i, j]);
            }
        }
    }
}


int message1 = GetintFromConsole("Enter number of rows = ");
int message2 = GetintFromConsole("Enter number of columns = ");
int message3 = GetintFromConsole("Enter Min value = ");
int message4 = GetintFromConsole("Enter Max value = ");
int[,] array = GetArray(message1, message2, message3, message4);
PrintArray(array);
WriteLine();
SortRowsInArray(array);
PrintArray(array);

