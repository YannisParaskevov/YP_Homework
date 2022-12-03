// выберите максимум уз 3х чисел
Console.Clear();
Console.Write("Введите первой число: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int third = int.Parse(Console.ReadLine());
int max = first; 
if(second > max) max = second;
if(third > max) max = third;
Console.WriteLine($"Максимальное число равно: {max}");
