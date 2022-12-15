// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
WriteLine();
FindMinSumRow(array);


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
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}
void FindMinSumRow(int[,] array)
{
    int MinSum = 0;
    for(int k = 0; k<array.GetLength(1); k++)
    {        
        MinSum += array[0,k];
    }
    int countMinSumRow = 0;
    for(int i=1; i<array.GetLength(0); i++)
    {
        int tempSum = 0;
         for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i,j];
        }
        if(tempSum<MinSum)
        {
            MinSum = tempSum;
            countMinSumRow = i;
        }
    }
Write($"номер строки с мин суммой -> {countMinSumRow+1} (мин сумма = {MinSum})");
}