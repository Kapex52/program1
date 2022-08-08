using System;
Console.WriteLine("Введте 1 число");
int number1=Convert.ToInt32(Console.ReadLine());
int prov=0;

while (prov=number1%2==0)
{
    Console.WriteLine(" чило " + number1 + " четное");
    prov++;
}

// else
// {
//     Console.WriteLine(" чило " + number1 + " НЕ четное");
// }