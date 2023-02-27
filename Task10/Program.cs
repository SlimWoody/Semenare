// 

int number  = new Random ().Next(100, 1000);
int firstDigit = number/100;
int secondDigit = number%10;
int result = firstDigit * 10 + secondDigit;
Console.WriteLine($"Случайное число отрезка {number} --> {result} ");

int FirstDigit (int num)
{
  int firstDigit = number/100;
  int secondDigit = number%10; 
  int result = firstDigit * 10 + secondDigit ;
  return result;
}
      