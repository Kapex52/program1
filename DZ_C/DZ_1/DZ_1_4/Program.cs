using System;
Console.WriteLine("Введте 1 число");
int number1=Convert.ToInt32(Console.ReadLine());
if (number1 > 0)
{
for (int i = 1; i <= number1; i++)
    if (i%2==0)
    {
    Console.WriteLine("Четные числа " + i);
    }
}

else
{
    Console.WriteLine("вычесление не возможно введеное число 0 или отрицательное " );
}

