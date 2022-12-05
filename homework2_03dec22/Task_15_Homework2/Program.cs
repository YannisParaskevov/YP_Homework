// принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Clear();
Console.Write("Введите цифру, обозначающую номер дня недели: ");
int num = int.Parse(Console.ReadLine());
if(num<1 || num>7) Console.WriteLine("Нет такого дня недели!");
string[] week = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};
string weekday = week[num-1];
if(num > 5)
{ 
    Console.WriteLine($"{num} -> Да");
    Console.WriteLine($"{num} это {weekday}, УРА, выходные!");
}
else    
{
    Console.WriteLine($"{num} -> Нет");
    Console.WriteLine($"{num} это {weekday}, рабочий день");
}
Console.WriteLine();
