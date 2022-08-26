// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
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
double[] massSumm = new double[rows];
for (int j = 0, k = 0; j < columns; j++)
{
    double summa = 0;
    for (int i = 0; i < rows; i++)
    {
        summa += resultMatrix[i, j];
    }
    massSumm[k] = summa / rows;
    Console.WriteLine("Среднее арифметическое столбца " + (k + 1) + " равно: " + massSumm[k]);
    k++;
}