// выберите максимум уз 2х чисел
Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
if(a == b) Console.WriteLine("числа a и b равны");
if(a > b) 
{
    Console.WriteLine($"max = {a}");
} 
else 
{
    Console.WriteLine($"max = {b}");
}