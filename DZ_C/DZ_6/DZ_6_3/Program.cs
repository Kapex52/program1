// Доп. задачка:
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.WriteLine("Ведите число");
int ishodniyNumber = Convert.ToInt32(Console.ReadLine());
int a = 0;
int i = 0;
string[] rezult = new string[ishodniyNumber];
while (ishodniyNumber >= 1)
{
    rezult[i] = Convert.ToString(ishodniyNumber % 2);
    i++;
    ishodniyNumber = ishodniyNumber / 2;
};
Array.Reverse(rezult);
Console.WriteLine($"Пересечение в точке: {String.Join("", rezult)}");