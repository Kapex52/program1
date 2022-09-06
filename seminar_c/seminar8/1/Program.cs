//Вот решение задачки № 53:
// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine()!);

int[,] matrix = new int[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
// i, j, m, k
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = new Random().Next(11);
}
}
void ChangeLines(int[,] matrix)
{
int lastIndex = matrix.GetLength(1);
for (int j = 0; j < lastIndex; j++)
{
int temp = matrix[0, j];
matrix[0, j] = matrix[lastIndex - 1, j];
matrix[lastIndex - 1, j] = temp;
}
}
void PrintArray(int[,] inputMatrix)
{
for (int i = 0; i < inputMatrix.GetLength(0); i++)
{
for (int j = 0; j < inputMatrix.GetLength(1); j++)
{
Console.Write(inputMatrix[i, j] + "\t"); // "\t" - Tab
}
Console.WriteLine();
}
}
PrintArray(matrix);
ChangeLines(matrix);
Console.WriteLine();
PrintArray(matrix);
