// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSumNum(int num)
{
  int sum = 0;
  for (int i = 0; num > 0; num /= 10)
  {
    i = num % 10;
    sum = sum + i;
  }
  return sum;
}

int num = new Random().Next(11, 10000);
Console.WriteLine(num);
Console.WriteLine(GetSumNum(num));