// вывести все четные числа от 1 до заданного N]
Console.Clear();
Console.Write("Введите положительное целое число больше 1: ");
int number = int.Parse(Console.ReadLine());
if(number>1) // с запятыми 
{
    int count = 2;
    Console.Write("Список четных чисел до заданного числа: ");
    Console.Write(count);
    count=count+2;
    while(count <= number)
    {
        Console.Write($", {count}");
        count=count+2;
    }
}
if(number>1) // без запятых
{
    int count = 2;
    Console.WriteLine();
    Console.Write("Список четных чисел до заданного числа: ");
        while(count <= number)
    {
        Console.Write($"{count} ");
        count=count+2;
    }
}
else
{
    Console.WriteLine("введено неверное число");
} 
