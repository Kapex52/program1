System.Console.WriteLine("Введте 1 число");
int number1=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введте 2 число");
int number2=Convert.ToInt32(Console.ReadLine());
if (number1==number2*number2)
{
   Console.WriteLine(number1 + " является квадратом от " + number2); 
}
else
{
    Console.WriteLine(number1 + " Не является квадратом от " + number2); 
}