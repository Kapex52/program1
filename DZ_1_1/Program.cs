Console.WriteLine("Введте 1 число");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введте 2 число");
int number2=Convert.ToInt32(Console.ReadLine());
if (number1 == number2)

{
   Console.WriteLine(number1 + " равно " + number2);
}
if (number1 > number2)
{
    Console.WriteLine(number1 + " болше " + number2);
}
if (number1 < number2)
{
    Console.WriteLine(number1 + " меньше " + number2);
}