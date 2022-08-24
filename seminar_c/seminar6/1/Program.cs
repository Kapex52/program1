// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// ///----
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// // Лучше вынести размер массива в отдельную переменную
// for (int i = 0; i < size; i++) // size = array.Length
// {
//     array[i] = new Random().Next(11); //[0;10]
//     Console.Write(array[i] + "\t"); // "\t" = tab
// }
// //---

// //0---
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// // Лучше вынести размер массива в отдельную переменную
// for (int i = 0; i < size; i++) // size = array.Length
// {
//     array[i] = new Random().Next(11); //[0;10]
//     Console.Write(array[i] + "\t"); // "\t" = tab
// }

// // 1 способ: поэлементо скопировать в новый массив
// // Копируем не слево направо, а справа налево
// Console.WriteLine();
// Console.WriteLine("Результат:");
// int [] resultArray = new int[size];
// int lastIndex = size - 1;
// for (int i = 0; i < size; i++)
// {
//     resultArray[i] = array[lastIndex - i];
//     Console.Write(resultArray[i] + "\t");
// }

// //----

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] reversArray=CopyArray(array);
Console.WriteLine(String.Join(" ", reversArray));

ReversArray(array);
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];
for (int i = 0; i < size; i++) // size = array.Length
{
res[i] = new Random().Next(minValue, maxValue + 1); // [0,5) => [0;4]
}
return res;
}

void ReversArray(int[] inArray)
{
for (int i = 0; i < inArray.Length / 2; i++)
{
int temp = inArray[i];
inArray[i] = inArray[inArray.Length - i - 1];
inArray[inArray.Length - i - 1] = temp;
}
}

int[] CopyArray(int[] inArray)
{
int[] result = new int[inArray.Length]; // size = inArray.Length
for (int i = 0; i < inArray.Length; i++)
{
result[i] = inArray[inArray.Length - 1 - i];

}
return result;

}
