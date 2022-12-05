/*Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 
1 строка*/

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

void SumDigitsInRow(int[,] inArray, int rows, int maxValue)
{
    int numberRow = 0;
    int finalSum = rows * maxValue;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            summ += inArray[i, j];
        }
        WriteLine($"Sum digits in row №{i + 1} = {summ}");
        if (summ < finalSum)
        {
            finalSum = summ;
            numberRow = i + 1;
        }
    }
    WriteLine($"Min sum in row № {numberRow}");
}

int message1 = GetintFromConsole("Enter number of rows = ");
int message2 = GetintFromConsole("Enter number of columns = ");
int message3 = GetintFromConsole("Enter Min value = ");
int message4 = GetintFromConsole("Enter Max value = ");
int[,] array = GetArray(message1, message2, message3, message4);
PrintArray(array);
SumDigitsInRow(array, message2, message4);