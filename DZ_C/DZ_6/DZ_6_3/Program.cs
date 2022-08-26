// Доп. задачка:
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.WriteLine("Ведите число");
int vvodDannih = Convert.ToInt32(Console.ReadLine());
int  ishodniyNumber= vvodDannih;
int i = 0;
string[] rezult = new string[vvodDannih];
while (vvodDannih >= 1)
{
    rezult[i] = Convert.ToString(vvodDannih % 2);
    i++;
    vvodDannih = vvodDannih / 2;
};
Array.Reverse(rezult);
Console.WriteLine($"десятичное число {ishodniyNumber} в двоисном виде {String.Join("", rezult)}");