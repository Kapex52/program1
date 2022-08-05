System.Console.WriteLine("Введте  число");
int number = Convert.ToInt32(Console.ReadLine());
int negativNumber=number*(-1);
while (negativNumber <= number)
{
    Console.WriteLine(negativNumber);
    negativNumber++;
} 

