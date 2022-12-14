// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;
Clear();
Console.WriteLine("Вводим данные для создания массива");
Write("Введите количество строк: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов : ");
int columns=int.Parse(ReadLine());
double[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите позицию элемента строка пробел столбец: ");
string position = Console.ReadLine();
ShowPosition(array, position);

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
            Write($" {array[i,j]:f3} |");
        }
        WriteLine();
    }
}
void ShowPosition(double[,] array, string pos)
{
    string[] stringPosition = pos.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int numPosRow = int.Parse(stringPosition[0]);
    int numPosCollumn = int.Parse(stringPosition[1]);
    if(numPosRow <= array.GetLength(0) && numPosCollumn <= array.GetLength(1)) 
    {
        Write($"[{numPosRow}{numPosCollumn}] -> Значение на этой позиции без округления -> {array[numPosRow-1,numPosCollumn-1]}"); 
    }
    else Write($"[{numPosRow}{numPosCollumn}] -> такой позиции в массиве нет");
}