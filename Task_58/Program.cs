/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

using static System.Console;
Clear();

int GetintFromConsole(string message)
{
    Write(message);
    return int.Parse(ReadLine()!);
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
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

int[,] MultitaskingMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        WriteLine("The matrices are not consistent.");
        return matrix2;
    }
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];

            }
        }
    }
    return matrix3;
}

int message1 = GetintFromConsole("Enter number of rows in matrix №1 = ");
int message2 = GetintFromConsole("Enter number of columns in matrix №1 = ");
int message3 = GetintFromConsole("Enter number of rows in matrix №2= ");
int message4 = GetintFromConsole("Enter number of columns in matrix №2 = ");
int[,] array1 = GetArray(message1, message2);
PrintArray(array1);
WriteLine();
int[,] array2 = GetArray(message3, message4);
PrintArray(array2);
WriteLine();
int[,] array3 = MultitaskingMatrix(array1, array2);
PrintArray(array3);
