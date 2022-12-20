// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
using System;
using static System.Console;

Clear();
WriteLine("Введите 2 натуральных числа (M и N) и я выведу сумму всех натуральных чисел в промежутке от M до N");
Write("Введите M: ");
int m=int.Parse(ReadLine());
Write("Введите N: ");
int n=int.Parse(ReadLine());
if(m<=0 || n<=0) {
WriteLine($"В принципе, я могу решить эту задачу и про целые числа, но в задании было про натуральные, а они больше 0"); 
return; }
if(m>n) WriteLine($"N = {n}; M = {m} -> сумма = {SumNumbers(n, m)}"); 
if(m<n) WriteLine($"M = {m}; N = {n} -> сумма = {SumNumbers(m, n)}");
if(m==n) WriteLine($"M = N  -> сумма = {m}");

int SumNumbers(int start, int end)
{
    if(start==end) return end; 
    return(start + SumNumbers(start+1, end));


}