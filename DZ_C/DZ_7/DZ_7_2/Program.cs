// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//17 -> такого числа в массиве нет

//Console.Write("Введите количество строк: ");
int rows = 3;
//Console.Write("Введите количество столбцов: ");
int columns = 4;
Console.Write("Введите 2 числа через пробел (от 0 до 10) первое число строка , второе стобец ");  
int[] pozition = Console.ReadLine().Split().Select(int.Parse).ToArray(); // да разобрался :)) там с дргим методом была проблема на занятиях уточню
double[,] GetArray(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 100, 1);
        }
    }
    return matrix;
}
double[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
void PrintArray(double[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
if (pozition[0] >= resultMatrix.GetLength(0) || pozition[1] >= resultMatrix.GetLength(1)) Console.WriteLine("такого числа в массиве нет");
else Console.WriteLine($" число {resultMatrix[pozition[0], pozition[1]]}");
