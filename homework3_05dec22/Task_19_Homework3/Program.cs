// принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
if(num < 10000 || num > 99999 )
{
    Console.WriteLine("Это не пятизначное число");
    return;
}
int[] toArray = new int[5];
int temp = num;
for(int i=4; i >= 0; i--)
{
    toArray[i] = temp%10;
    temp = temp/10;
}
if((toArray[0] == toArray[4]) && (toArray[1] == toArray[3])) Console.WriteLine($"{num}  ->  да, это палиндром");
else Console.WriteLine($"{num}  ->  нет, это не палиндром");