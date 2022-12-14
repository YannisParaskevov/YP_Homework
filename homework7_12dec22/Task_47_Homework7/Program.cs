// // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());
Console.WriteLine("Зададим диапазон для чисел в массиве");
Console.Write("введите значение нижней границы (включительно) min = ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите значение верхней границы (включительно) max = ");
int max = int.Parse(Console.ReadLine());
double[,] array = GetArray(rows, columns, min, max);

PrintArray(array);

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (max-min) + min; 
        }
    }
    return result;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]>=0) Write($" {array[i,j]:f3} ");
            else Write($"{array[i,j]:f3} ");
        }
        WriteLine();
    }
}
