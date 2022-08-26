// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите число элеменов масива:");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(35) +  Math.Round(new Random().NextDouble(), 2);  /// Math.Round(testDecimal, 2, MidpointRounding.AwayFromZero))
    Console.Write(array[i] + " ");
    Console.WriteLine(" ");
}
double findMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < size; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}
double findMax(double[] array)
{
    double max = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}
Console.WriteLine($"разница между максимальным  {findMax(array)} и минимальным {findMin(array)} элементом массива = {findMax(array) - findMin(array)}");
