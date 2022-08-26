List<int> digits = new List<int>();
 
while (true)
{
  var digit = int.parse(Console.ReadLine());
  if (digit==42)
    break;
  digits.Add(digit);
}
