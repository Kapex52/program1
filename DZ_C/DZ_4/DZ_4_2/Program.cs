// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());
int sum = 0;
int SumNumbers(int number)
{
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
if (number < 0) number = number * -1;
Console.WriteLine($"сумма чисел числа {number} равна {SumNumbers(number)}");
