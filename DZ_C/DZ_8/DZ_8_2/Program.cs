// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int m = 4;
int n = 7;
int[,] array = new int[m, n];

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
            Console.WriteLine();
    }
}

CreateArray(array);

int minSum = 0;
int sumLine = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSum = SumLine(array, i);
    if (sumLine > tempSum)
    {
        sumLine = tempSum;
        minSum = i;
    }
}

int SumLine(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}
Console.WriteLine();
WriteArray(array);
Console.WriteLine();
Console.WriteLine($"{minSum + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");
Console.WriteLine();