Console.WriteLine("Введте 1 число");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введте 2 число");
int number2=Convert.ToInt32(Console.ReadLine());
if (number1 == number2)

{
   Console.WriteLine(" число 1 равное " + number1 + " РАВНО числу 2 равное " + number2);
}
if (number1 > number2)
{
      Console.WriteLine(" число 1 равное " + number1 + " БОЛЬШЕ числа 2 равное " + number2);
}
if (number1 < number2)
{
    Console.WriteLine(" число 2 равное" + number2 + " БОЛЬШЕ числа 1 равное " + number1);
}