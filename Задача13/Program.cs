// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введи число");
int number = int.Parse(Console.ReadLine());
int num = 0;

if (number > 99)
{

    while (number > 1000 && number > 99)
    {
        number = number / 10;
    }


    num = number % 10;
    System.Console.WriteLine($"Третья цифра = {num}");

}

else
{
    System.Console.WriteLine("Третьей цифры нет");
}



