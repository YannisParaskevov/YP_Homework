// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
double[] PrintArrayFromString(string array)
{
    string[] elements = array.Split("/", StringSplitOptions.RemoveEmptyEntries);
    double[] res = new double[elements.Length];

    for (int i = 0; i < elements.Length; i++)
    {
        res[i] = double.Parse(elements[i]);
    }
    Console.Write($"В массиве [{string.Join("; ", res)}] ");
    return res;
}
int HawManyPositivs(double[] array)
{
    int countPositivs = 0;
    foreach(double item in array)
        {
        if(item>0) countPositivs++;
        }
    return countPositivs;
}
Console.Clear();
Console.Write("Введите элементы массива через слэш(/) без пробелов: ");
string numbers = Console.ReadLine();
double[] array = PrintArrayFromString(numbers);
Console.WriteLine($"количество положительных чисел -> {HawManyPositivs(array)}");


