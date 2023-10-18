// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введи первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число");
int b = int.Parse(Console.ReadLine()!);
int max = 0;
int min = 0;

if (a < b)
{
    max = b;
    min = a;
}
else
{
    max = a;
    min = b;
}

Console.WriteLine("max= " + max);
Console.WriteLine("min= " + min);