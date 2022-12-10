// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] FillPrintArray(double[] array, int min, int max) 
{
    Console.WriteLine();
    for(int i =0; i < array.Length; i++)
    {
      array[i] = Math.Round(new Random().NextDouble() * (max-min) + min, 3); // округляю для лучшего восприятия на экране
    }
    Console.Write($"Получившийся массив из {array.Length} элементов:[{string.Join("; ",array)}]");
    Console.WriteLine();
    return array;
}
double DifMinMax (double[] arr) 
{
    Console.WriteLine();
    double dif = 0;
    double arrMin= arr[0];
    double arrMax= arr[0];
    {
        for(int i=1; i<arr.Length; i ++)
        {
            if(arr[i]>arrMax) arrMax = arr[i];
            if(arr[i]<arrMin) arrMin = arr[i];
        }
        dif = arrMax - arrMin;
        Console.WriteLine($"В этом массиве макс.эл-т = {arrMax}; мин. эл-т = {arrMin}");
        Console.WriteLine();
        return dif; 
    }
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
double[] array = new double[ind]; 
FillPrintArray(array, min, max);

Console.WriteLine($"Разница между ними = {DifMinMax(array):f3}");
Console.WriteLine();