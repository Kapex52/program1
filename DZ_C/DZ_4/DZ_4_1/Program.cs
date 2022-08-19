// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введте  число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введте  положительное число");
int number2 = Convert.ToInt32(Console.ReadLine());
int rezult = number1;
if (number2 == 0)
{
    Console.WriteLine($"чило {number1}^{number2}=1");
}
if (number2 > 0)
{
    for (int i = 1; i < number2; i++)
    {
        rezult = rezult * number1;
    }
    Console.WriteLine($"чило {number1}^{number2}={rezult}");
}
if (number2 < 0)
{
    Console.WriteLine("введено отрицателное число");
}