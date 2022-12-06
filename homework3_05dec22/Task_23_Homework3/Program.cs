// принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.Write("Введите любое целое число: ");
int num = int.Parse(Console.ReadLine());
if(num == 0)  
{
    Console.WriteLine("Ноль в кубе это все равно ноль"); 
    return;
}
int sign = 1;
if(num<0) sign = -1;
int aux = Math.Abs(num);
Console.Write($"{num} ->    ");
for(int i=1; i<= aux; i++)
{
    Console.Write($"{Math.Pow(i,3) * sign} ");
}