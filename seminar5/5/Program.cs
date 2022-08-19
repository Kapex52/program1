// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


// int[] array = {-4, -8, 8, 2};

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = -array[i];
//     Console.Write(array[i] + " ,");
// }


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// int[] array = {6,7,19,345,3};

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// bool pos = false;

// for (int i = 0; i < array.Length; i++)
// {
//     if (num == array[i])
//     {
//         pos = true;
//         break;
//     }
// }

// if (pos == true) Console.WriteLine("Число " + num + " есть в массиве");
// if (pos == false) Console.WriteLine("Числа " + num + " НЕТ в массиве");


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = new int [10];

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(150);
    Console.Write(array[i] + " ,");

    if (array[i] >= 10 && array[i] <= 99) count++;
}
Console.WriteLine();
Console.WriteLine(count);
