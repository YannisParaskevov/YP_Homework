// принимает на вход число и выдаёт сумму цифр в числе.
int SumNumbers (int a)
{
int Sum = 0;

    while(a>0)
    {
        Sum = Sum + a%10;
        a=a/10;
    }
return Sum;
}
Console.Clear();
Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());
int aux = Math.Abs(num);
Console.WriteLine($"Сумма цифр в числе {num}  -->  {SumNumbers(aux)}");
