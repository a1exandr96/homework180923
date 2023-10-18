// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int Prompt(string msg)
{
	Console.Write(msg);
	int res = int.Parse(Console.ReadLine());
	return res;
}

int NatNum(int a, int b)
{
	if (a == b)
	{
		return a;
	}
	else
	{
		Console.Write($"{NatNum(a, b + 1)}, ");
		return b;
	}
}

int a = Prompt("Введите положительное число N: ");
if (a < 1)
{
	Console.WriteLine($"Число {a} не положительное ");
	return;
}
Console.WriteLine(NatNum(a, 1));