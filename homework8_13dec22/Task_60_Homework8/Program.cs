// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System;
using static System.Console;
Clear();
Write("Введите глубину 3х-мерного массива: ");
int x=int.Parse(ReadLine());
Write("Введите количество строк 3х-мерного массива: ");
int y=int.Parse(ReadLine());
Write("Введите количество столбцов 3х-мерного массива: ");
int z=int.Parse(ReadLine());
if(x*y*z < 90)
{
int[] forUnrepeatedNumbers = new int[x*y*z];
FillNonRepeatedArray(forUnrepeatedNumbers);
Write($"Неповторяющиеся числа для заполнения 3-хмерного массива: \r\n[{string.Join("; ",forUnrepeatedNumbers)}]");
WriteLine();
WriteLine();
int[,,] threeDimArray = Fill3DimArrayFrom1Dim(x,y,z, forUnrepeatedNumbers);
Print3DimArray(threeDimArray);
}
else 
{
    Write("Не сработает, т.к. не получится не повторять числа");
    return;
}

int[] FillNonRepeatedArray(int[] array) 
{
    for(int i =0; i < array.Length; i++)
    {
      array[i] = new Random().Next(10,99);
      int j=0;
      while(j<i)
        if(array[i] == array[j])
        {
            array[i] = new Random().Next(10,99);
            j = 0;
        }
        else j++;
    }
    return array;
}
int[,,] Fill3DimArrayFrom1Dim(int x, int y, int z, int[] array)
{
    int[,,] result = new int[x,y,z];
    for(int i=0; i<x; i++)
    {
        for(int j=0; j<y; j++)
        {
            for(int k=0; k<z; k++)
            {
                result[i,j,k]=array[k + j*z + i*z*y];
            }
        }
    }
return result;
}
void Print3DimArray(int [,,] array)
{
for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for(int k=0; k<array.GetLength(2); k++)
            {
                Write($" {array[i,j,k]}({i}{j}{k}) ");
            }
        WriteLine();
        }
    WriteLine();
    }

}