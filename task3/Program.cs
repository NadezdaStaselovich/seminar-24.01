// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetRandomArray(int length)
{
  int[] result = new int[length];

  for(int i = 0; i < length; i++)
  { 
    result[i] = new Random().Next(0, 10);
  }
  return result;
}
void PrintArray(int[] arr)
{ 
  foreach(int item in arr) 
  {
    System.Console.Write(item + ",");
  }
}

int[] arr = GetRandomArray(8);
PrintArray(arr);