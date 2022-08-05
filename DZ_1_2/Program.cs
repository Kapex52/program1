Console.WriteLine("Введте 1 число");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введте 2 число");
int number2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введте 3 число");
int number3=Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number1 == number2)
    {
if (number3 == number2)
Console.WriteLine(" все равны" + max);
    }

if (number1 < number2)
{
   if (number2 < number3)
   {
    max=number3;
    Console.WriteLine(" наиболшее число  " + max);
   }
    max=number2;
    Console.WriteLine(" наиболшее число  " + max);
}
else
if (number1 > number3)
{
    Console.WriteLine(" наиболшее число  " + max);
}

   // max=number3;
   // Console.WriteLine(" наиболшее число  " + max);