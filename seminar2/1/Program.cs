
int number = new Random().Next(10,100);
Console.WriteLine(number);

int ferstDigit = number / 10;
int secondDigit = number % 10;
int maximum = ferstDigit;
if (secondDigit > ferstDigit) maximum = secondDigit;
Console.WriteLine($"Максимальная цивпа в чсле {number} - это {maximum}");



