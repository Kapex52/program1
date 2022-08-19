// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите число элеменов масива:");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
double min=array[0];
double max=0;
for (int i = 0; i < size; i++)

{
    array[i] = new Random().Next(20) + new Random().NextDouble();
    Console.Write(array[i] + " ");
    Console.WriteLine(" ");
}
// for (int j = 1; j < size; j++)
//         {
//             if (array[j] > max) max = array[j];
//             if (array[j] < min) min = array[j];
//            }
double findMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < size; i++)
    {
        if (i < min) min = i;
    }
    return min;
}

// double findMax(double[] array)
// {
//     double max = 0;
//     for (int i = 0; i < size; i++)
//     {
//         if (i > max) max = i;
//     }
//     return arramax;
// }
Console.WriteLine($"разница между максимальным  {findMin(array)} и минимальным {findMin(array)} элементом массива ");


Console.WriteLine("Minimum number is " + findMin(array));
//Console.WriteLine("Maximum number is " + findMax(array));

// Console.WriteLine($"количество четных чисел в массиве {max}");
// Console.WriteLine($"количество четных чисел в массиве  min {min}");