using System.Drawing;
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите число");
string? number = Console.ReadLine();
int i = 0, size = number.Length - 1;
while ((i < size) && (number[i] == number[size]))
{ i++; size--; }
if (number[i] == number[size])
    Console.WriteLine("Введенное число: " + "\t" + number + "\t" + " палиндром");
else
    Console.WriteLine("Введенное число: " + "\t" + number + "\t" + " НЕ палиндром");

