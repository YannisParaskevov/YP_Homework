// принимает на вход число и выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Clear();
Console.Write("Введите положительное целое число: ");
int num = int.Parse(Console.ReadLine());
if(num<100) 
{
    Console.WriteLine($"{num} -> третьей цифры нет");
    return;
}
int aux = num;
while(aux > 999)
{
        aux = aux  / 10;
}
int third_num = aux % 10; 
Console.WriteLine($"{num} -> {third_num}");