// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[] ArrayFromString(string array)
{
    string[] elements = array.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    double[] res = new double[elements.Length];

    for (int i = 0; i < elements.Length; i++)
    {
        res[i] = double.Parse(elements[i]);
    }
        return res;
}
double[] CrossPoint(double[] firstLine, double[] secondLine)
{
    double[] result = new double[2];
    result[0] = (secondLine[1] - firstLine[1])/ (firstLine[0] - secondLine[0]);
    if(result[0] == 0) result[0]=Math.Abs(result[0]);
    result[1] = result[0]*firstLine[0]+firstLine[1];
    if(result[1] == 0) result[1]=Math.Abs(result[1]);
    return result;
}

Console.Clear();
Console.WriteLine("Эта программа найдет координаты точки пересечения двух прямых y=k*x + b");
Console.Write("Введите через пробел k1 и b1 для первой прямой: ");
string first = Console.ReadLine();
double[] firstLine = ArrayFromString(first);
Console.Write("Введите через пробел k2 и b2 для второй прямой: ");
string second = Console.ReadLine();
double[] secondLine = ArrayFromString(second);
if(firstLine.Length != 2 || secondLine.Length != 2) 
    {
        Console.WriteLine("Коэффициенты прямых введены с ошибкой, попробуйте еще раз");
        return;
    }
if(firstLine[0] == secondLine[0]) 
    {
        Console.WriteLine("Эти прямые не пересекаются - они параллельны!");
        return;
    }
else
    {
    double[]coordinateCrossPoint = CrossPoint(firstLine, secondLine);
    Console.WriteLine($"Координаты точки пересечения этих прямых ({coordinateCrossPoint[0]:f3}; {coordinateCrossPoint[1]:f3}) (Округлено до тысячных)");
    }