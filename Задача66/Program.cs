


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string msg)
{
	Console.Write(msg);
	int res = int.Parse(Console.ReadLine());
	return res;
}

int Sum(int m, int n)
{
	if (m == n)
	{
		return m;
	}

	else
	{
		return Sum(m + 1, n) + m;
	}

}

int m = Prompt("Введи число M: ");
int n = Prompt("Введи число N: ");

Console.WriteLine(Sum(m, n));