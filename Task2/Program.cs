// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите x координату точки 1: ");
int xa1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y координату точки 1: ");
int ya1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z координату точки 1: ");
int za1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите x координату точки 2: ");
int xb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y координату точки 2: ");
int yb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z координату точки 2: ");
int zb1 = Convert.ToInt32(Console.ReadLine());

double GetDist3D(int xa, int ya, int xb, int yb, int za, int zb)
{
    double dx = xa - xb;
    double dy = ya - yb;
    double dz = za - zb;
    return Math.Sqrt(dx * dx + dy * dy + dz * dz);
}

double result = GetDist3D(xa1, xb1, za1, ya1, yb1, zb1);
Console.WriteLine($"A ({xa1}, {ya1}, {za1}), B ({xb1}, {yb1}, {zb1}) --> {Math.Round(result, 2, MidpointRounding.ToZero)}"); // округляем при помощи Math.Round()