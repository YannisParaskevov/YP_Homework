// является ли число четным
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int even = number%2;
if(even == 0)
{
    Console.WriteLine($"Да, число {number} четное");
} 
else
{
    Console.WriteLine($"Нет, число {number} нечетное");
}