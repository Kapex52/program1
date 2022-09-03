// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.WriteLine();
Console.Write("ведите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("ведите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"N={n}, M={m}");
Console.WriteLine();
if (m > n)
    for (int i = n; i <= m; i++)
        Console.Write($" {i}");
else
    for (int i = m; i <= n; i++)
        Console.Write($" {i}");
Console.WriteLine();
Console.WriteLine();