// принимает на вход координаты двух точек  и находит расстояние между ними в 3D пространстве
Console.Clear();
Console.Write("Введите координату x точки А: ");
double xa = double.Parse(Console.ReadLine());
Console.Write("Введите координату y точки А: ");
double ya = double.Parse(Console.ReadLine());
Console.Write("Введите координату z точки А: ");
double za = double.Parse(Console.ReadLine());
Console.Write("Введите координату x точки B: ");
double xb = double.Parse(Console.ReadLine());
Console.Write("Введите координату y точки B: ");
double yb = double.Parse(Console.ReadLine());
Console.Write("Введите координату z точки B: ");
double zb = double.Parse(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(xa-xb,2) + Math.Pow(ya-yb, 2) +Math.Pow(za-zb, 2));
Console.WriteLine($"A({xa};{ya};{za}); B({xb};{yb};{zb}) -> d = {d:f2}");