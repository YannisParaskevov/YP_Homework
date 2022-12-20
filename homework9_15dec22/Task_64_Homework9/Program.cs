// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// M = 5; N = 3 -> "5, 4, 3"
// M = 8; N = 4. -> "8, 7, 6, 5, 4"
using System;
using static System.Console;

Clear();
WriteLine("Введите 2 натуральных числа (M и N) и я выведу все натуральные числа в промежутке от большего к меньшему");
Write("Введите M: ");
int m=int.Parse(ReadLine());
Write("Введите N: ");
int n=int.Parse(ReadLine());
if(m<=0 || n<=0) {
WriteLine($"В принципе, я могу решить эту задачу и про целые числа, но в задании было про натуральные, а 0они больше 0"); 
return; }
if(m>n) WriteLine($"M = {m}; N = {n} -> {PrintNumbers(m, n)}"); 
if(m<n) WriteLine($"N = {n}; M = {m} -> {PrintNumbers(n, m)}");
if(m==n) WriteLine($"M = N = {m}");

string PrintNumbers(int start, int end)
{
    if (end == start) 
     return start.ToString();
    return (start + ", " + PrintNumbers(start - 1, end));
}