// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());


void PrintQuart(int a)
{
    if (n >= 0)
    {
        for (int i = 1; i <= a; i++) // Перебираем в цикле For от 1 до a
        Console.WriteLine($"*|{i}|* \t *|{i * i * i}|*"); // t\ - это цифра с новой строчки
    }
    

    if (n < 1) 
    {
        Console.WriteLine("Введите число > 1");
        return;
    }
}
    PrintQuart(n);