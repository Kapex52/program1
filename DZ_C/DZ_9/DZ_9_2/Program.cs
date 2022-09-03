// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine();
Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int proverka = m;
int sum = 0;

if (m > n)
{
    m = n;
    n = proverka;
}

void PrintSumm(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов= {sum} ");
        return;
    }
    PrintSumm(m, n - 1, sum);
}

PrintSumm(m, n, sum);
Console.WriteLine();
Console.WriteLine();