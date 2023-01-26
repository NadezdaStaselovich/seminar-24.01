//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetPowNumber(int num1, int num2)
{
  int result = 1;

  for(int i = 0; i < num2; i++)
  {
    result *= num1;
  }
  return result;
}

int num1 = new Random().Next(2, 5);
int num2 = new Random().Next(2, 5);
Console.WriteLine($"{num1}, {num2}");
Console.WriteLine(GetPowNumber(num1, num2));
