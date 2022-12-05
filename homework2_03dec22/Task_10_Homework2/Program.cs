// принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Clear();
Console.Write("Введите целое трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int aux = num / 10;
Console.WriteLine($"{num} -> {aux % 10}");
