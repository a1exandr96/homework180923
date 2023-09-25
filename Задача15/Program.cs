// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введи номер дня недели");
int num = int.Parse(Console.ReadLine());

if (num == 6 || num == 7)
{
    System.Console.WriteLine("Да");
}

else if (num > 0 && num < 6)
{
    System.Console.WriteLine("Нет");
}

else
{
    System.Console.WriteLine("Это не день недели");
}

