// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19     [-4, -6, 89, 6] -> 0

int[] FillPrintArray(int[] array, int min, int max) 
{
    Console.WriteLine();
    Console.Write($"Получившийся массив из {array.Length} элементов: ");
    for(int i =0; i < array.Length; i++)
    {
      array[i] = new Random().Next(min,max+1);
    }
    Console.Write($"[{string.Join(", ",array)}]");
    Console.WriteLine();
    return array;
}
int SumNotEven (int[] arr) // нумерация по программированию 0, 1, 2, 3 ...
{
    int Sum = 0;
    if(arr.Length == 1) return Sum;
    for(int i=1; i<arr.Length; i +=2)
    {
        Sum += arr[i];
    }
    return Sum;
}
Console.Clear();
Console.Write("Введите количество элементов в массиве N = ");
int ind = int.Parse(Console.ReadLine());
if(ind < 1) 
{
    Console.WriteLine("Ошибка в условиях, N - натуральное число, попробуйте еще раз");
    return;
}
Console.WriteLine("Зададим диапазон для чисел в массиве");
Console.Write("введите значение нижней границы (включительно) min = ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите значение верхней границы (включительно) max = ");
int max = int.Parse(Console.ReadLine());
if(min > max) 
{
    Console.WriteLine("Ошибка в условиях, min < max, попробуйте еще раз");
    return;
}
int[] array = new int[ind]; 
FillPrintArray(array, min, max);
Console.WriteLine();
Console.WriteLine($"В этом массиве сумма элементов на нечетных позициях = {SumNotEven(array)}");
Console.WriteLine();