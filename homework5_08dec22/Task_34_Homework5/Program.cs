// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] FillPrintArray(int[] array, int min, int max) 
{
    Console.WriteLine();
    Console.Write($"Получившийся массив из {array.Length} элементов: ");
    for(int i =0; i < array.Length; i++)
    {
      array[i] = new Random().Next(min,max);
    }
    Console.Write($"[{string.Join(", ",array)}]");
    return array;
}
int HMEven(int[] array)
{
    int count = 0;
    foreach (int i in array)
    {
    if(i % 2 == 0) count++;
    }
    Console.WriteLine();
    return count;
}
Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int ind = int.Parse(Console.ReadLine());
if(ind<1) 
{
    Console.WriteLine("Введено неверное число, попробуйте еще раз");
    return;
}

int[] array = new int[ind]; 
FillPrintArray(array, 100, 1000);
Console.WriteLine();
Console.WriteLine($"Количество четных эл-ов в этом массиве  -> {HMEven(array)}");
Console.WriteLine();