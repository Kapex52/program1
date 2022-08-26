//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m + n.Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

//Console.WriteLine("Введите два числа: ");
//int rows = Convert.ToInt32(Console.ReadLine());
//int columns = Convert.ToInt32(Console.ReadLine());

//int[,] numbers = new int[rows, columns];

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        numbers[i, j] = i + j;
//        Console.Write(numbers[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Console.WriteLine("Введите два числа: ");
//int rows = Convert.ToInt32(Console.ReadLine());
//int columns = Convert.ToInt32(Console.ReadLine());

//int[,] numbers = new int[rows, columns];

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        numbers[i, j] = new Random().Next(11);
//        if (i % 2 == 0 && j % 2 == 0)
//        {
//            numbers[i, j] = numbers[i, j] * numbers[i, j];
//        }
//        Console.Write(numbers[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

//Задача 51.Найти сумму элементов главной диагонали.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Сумма элементов главной диагонали: 1 + 9 + 2 = 12


Console.WriteLine("Введите два числа: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[rows, columns];
int sum = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        numbers[i, j] = new Random().Next(11);
        if (i == j)
        {
            sum = sum + numbers[i, j];
        }
        Console.Write(numbers[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine(sum);
           