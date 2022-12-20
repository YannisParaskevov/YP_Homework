// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
using System;
using static System.Console;
Clear();
WriteLine("Введите два неотрицательных целых числа (m и n) и я выведу значение финкции Аккермана А(m, n)");
Write("Введите m: ");
int m=int.Parse(ReadLine()); 
Write("Введите n: ");
int n=int.Parse(ReadLine());
if(m<0 || n<0) {
WriteLine($"Нужны неотрицательные целые числа"); 
return; }
WriteLine($"m = {m}; n = {n} -> A(m, n) = {Akkerman(m, n)}"); 

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else 
  {
    if ((m != 0) && (n == 0)) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
  }
}