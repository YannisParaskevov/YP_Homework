// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;
Clear();
Write("Через пробел введите количество строк и столбцов первой матрицы: ");
string string1Matrix = Console.ReadLine();
int[] size1Matrix = ArrayFromString(string1Matrix);
Write("Через пробел введите количество строк и столбцов второй матрицы: ");
string string2Matrix = Console.ReadLine();
int[] size2Matrix = ArrayFromString(string2Matrix);
if(size1Matrix[1] != size2Matrix[0]) 
    {
    WriteLine();
    Write("Найти произведение этих матриц невозможно (кол-во стоолбцов 1-го множителя должно быть равно кол-ву строк 2-го множителя)");
    return;
    }
int[,] matrix1 = GetArray(size1Matrix[0], size1Matrix[1]);
PrintArray(matrix1);
WriteLine("x");
int[,] matrix2 = GetArray(size2Matrix[0], size2Matrix[1]);
PrintArray(matrix2);
WriteLine("-------------------");
int[,] ProductMatrix12 = ProductMatrix(matrix1, matrix2);
PrintArray(ProductMatrix12);
WriteLine();



int[] ArrayFromString(string array)
{
    string[] elements = array.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[elements.Length];
     for (int i = 0; i < elements.Length; i++)
     {
         res[i] = int.Parse(elements[i]);
     }
    return res;
}
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
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
int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int i=0; i< matrix1.GetLength(0); i++)
    {
        for(int j=0; j<matrix2.GetLength(1); j++)
        {
            for(int k=0; k<matrix2.GetLength(0); k++)
            {
                result[i,j] += matrix1[i,k]*matrix2[k,j];
            }
        }
    }
    return result;
}