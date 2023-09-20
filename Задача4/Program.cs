// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

Console.WriteLine("Enter 1st num");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 2nd num");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Enter 3rd num");
int c = int.Parse(Console.ReadLine());
int max = a;

if (max < b)
{
    max = b;
}

else if (max < c) 
{
    max = c;
}

Console.WriteLine("max = " + max);