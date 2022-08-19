// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Нужно сделать через числа, без индексов строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int number = new Random().Next(100,1000);
// Console.WriteLine(number);

Console.WriteLine("Введите ТРЕХзначное число");
int number=Convert.ToInt32(Console.ReadLine());
if (99 < number && number < 1000)
{
int rez1 = number / 10;
int rez2 = rez1 % 10;
Console.WriteLine($"Число {number} - его 2 цифра {rez2}");
}
else
Console.WriteLine("вы вели  НЕ трехзначное число");