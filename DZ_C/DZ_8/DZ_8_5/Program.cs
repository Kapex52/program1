// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int n = 4;
int[,] array = new int[n, n];
int i = 0;
int j = 0;
int zaponenie = 1;
while (zaponenie <= array.GetLength(0) * array.GetLength(1))
{
    array[i, j] = zaponenie;
    zaponenie++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
}
Console.WriteLine();
Console.WriteLine($"Спиральный массив {n} на {n}");
Console.WriteLine();
WriteArray(array);
void WriteArray(int[,] spiralArrey)
{
    for (int i = 0; i < spiralArrey.GetLength(0); i++)
    {
        for (int j = 0; j < spiralArrey.GetLength(1); j++)
        {
            if (spiralArrey[i, j] / 10 <= 0)
                Console.Write($" {spiralArrey[i, j]} ");

            else Console.Write($"{spiralArrey[i, j]} ");
        }
        Console.WriteLine();
    }
     Console.WriteLine();
}
