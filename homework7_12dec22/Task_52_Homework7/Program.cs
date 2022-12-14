// адайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;
Clear();
Write("Введите количество строк: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов : ");
int columns=int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
WriteLine();
AverageInCollumns(array);
WriteLine();

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"   {array[i,j]}   ");
        }
        WriteLine();
    }
}
void AverageInCollumns(int[,] array)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        double tempSum = 0;
        for(int i=0; i<array.GetLength(0); i++)
            {
                tempSum = tempSum + array[i,j];
            }
    Write($" {tempSum/array.GetLength(0):f3} ");
    }
WriteLine();
}