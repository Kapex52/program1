// // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// // 4; массив [6, 7, 19, 345, 3] -> нет
// // -3; массив [6, 7, 19, 345, 3] -> да
// int[] array = { -2, -1, 0, 1, 2 };

// int findNumber = 22;

// bool flagResult = false; // bool = false,true
// // flagResult = false - element not found
// // flagResult = true - element found

// for (int i = 0; i < array.Length; i++)
// {
//     if (findNumber == array[i]) 
//     {
//         flagResult = true;
//         break; // ломает цикл - цикл останавливается
//     }
// }
// // 1 - true, 0 - false
// if (flagResult) Console.WriteLine("Element found"); // flagResult == true -> if (flagResult)
// else Console.WriteLine("Element NOT found");

int[] array = { -2, -1, 0, 1, 2 };
int findNumber = 2;
string flagResult = "не найден";
// flagResult = false - element not found
// flagResult = true - element found
for (int i = 0; i < array.Length; i++)
{
    if (findNumber == array[i]) 
    {
        flagResult = "найден";
        break; // ломает цикл - цикл останавливается
    }
}
Console.WriteLine($"Элемент: {flagResult}");
