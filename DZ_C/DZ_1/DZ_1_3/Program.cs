using System;
Console.WriteLine("Введте 1 число");
int number1=Convert.ToInt32(Console.ReadLine());
int prov=number1%2;

if (prov==0)
{
    Console.WriteLine(" чило " + number1 + " четное");
}
else
{
    Console.WriteLine(" чило " + number1 + " НЕ четное");
}