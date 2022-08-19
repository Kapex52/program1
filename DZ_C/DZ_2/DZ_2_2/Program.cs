// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
string? number = Console.ReadLine();
int size = number.Length;
if (size > 2)
    {
    Console.WriteLine($"Третья цифра числа {number[2]} ");
    }
else Console.WriteLine($"вы вели слишком маленькое число");

