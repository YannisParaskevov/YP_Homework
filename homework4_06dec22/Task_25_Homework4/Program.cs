// принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
double Exponent(double a, int b)
{
double result = 1;
    for(int i=1; i<=b; i++)
    {
        result = result * a;
    }
return result;
}
Console.Clear();
Console.Write("Введите основание степени: ");
double num = double.Parse(Console.ReadLine());
Console.Write("Введите показатель степени (натуральное число): ");
int exp = int.Parse(Console.ReadLine());
if(exp > 0) 
{
    Console.WriteLine($"{num} в степени {exp}  -->  {Exponent(num, exp)}");
}
else
{
   Console.WriteLine ("Введено неправильный показатель степени");
}

