
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру от 1 до 7");
int number=Convert.ToInt32(Console.ReadLine());
if (0 < number && number < 8)
{
    if (6 == number || number == 7)
    {
        Console.WriteLine("Да");
    }
    else Console.WriteLine("Нет");
}   
else Console.WriteLine($"Число {number} - не входит в заданный интервал ");

