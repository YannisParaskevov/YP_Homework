// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using static System.Console;
Clear();
WriteLine("Я умею заполнять прямоугольные массивы по спирали");
Write("Введите количество строк: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int collumns=int.Parse(ReadLine());
int[,] spiralArray = new int[rows,collumns];
SpiralFillPrintArray (spiralArray);
PrintArray(spiralArray);

int[,] SpiralFillPrintArray(int [,] array)
{
    int count = 0;
    int countMax = array.GetLength(0)*array.GetLength(1);
    int countLines =0;
    if(array.GetLength(0)>array.GetLength(1)) countLines = array.GetLength(0)/2+1;
    else countLines = array.GetLength(1)/2+1;
    for(int m = 0; m<countLines; m++)
    {
        for(int j=m; j < array.GetLength(1)-m; j++) // идем вправо
        {
            count++;
            if(count>countMax) return array;
            array[m, j] = count;
        }
        for (int i=m+1; i<array.GetLength(0)-m; i++) // идем вниз
        {
            count++;
            if(count>countMax) return array;
            array[i, array.GetLength(1)-m-1] = count;
        }
        for(int k=array.GetLength(1)-m-2; k>m-1; k--) // идем влево
        {
            count++;
            if(count>countMax) return array; 
            array[array.GetLength(0)-m-1, k] = count;
        }
        for(int l=array.GetLength(0)-m-2; l>m; l--) // идем вверх
        {
            count++;
            if(count>countMax) return array;
            array[l, m] = count;
        }
    }
return array;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(inArray[i,j] <10) Write($"0{inArray[i,j]} ");
            else Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}