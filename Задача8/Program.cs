﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Enter num");
int a = int.Parse(Console.ReadLine()!);
int res = 1;

if (res == 1)

{
    res += 1;
}

while (res <= a)

{

    Console.Write(res + " ");
    res += 2;
}
