// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int n = 2;
int[,] firstArray = new int[n, n];
int[,] secomdArray = new int[n, n];
int[,] resultMatrix = new int[n, n];

void ProizvedenieArray(int[,] firstArray, int[,] secomdArray, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum += firstArray[i, k] * secomdArray[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

CreateArray(firstArray);
Console.WriteLine();
Console.WriteLine("Первая матрица:");
WriteArray(firstArray);
CreateArray(secomdArray);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
WriteArray(secomdArray);
ProizvedenieArray(firstArray, secomdArray, resultMatrix);
Console.WriteLine();
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);