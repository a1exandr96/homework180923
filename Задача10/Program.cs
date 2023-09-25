// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введи трехзначное число");
int number = int.Parse(Console.ReadLine());
int num = 0;

if (number > 99 && number < 1000)
{
    num = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра {number} = {num}");
}

else
{
    Console.WriteLine($"Число {number} не является трехзначным");
}