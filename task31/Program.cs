/*
Задайте массив из 12 элементов, заполненый случайными числами
из промежутка [-9, 9]. найдите сумму отрицательных и положительных
элементов массива.
Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/ 


Console.Clear();


int[] GetRnd(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
       array[i] = new Random().Next(min, max + 1);
    }
    return array;
    System.Console.Write(array + " ");
}

/*void SumArray(int[] arr)
{
    int summPos = 0;
    int summNeg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) summPos = summPos + arr[i];   метод правильный и подходит для решение данной задачи
        else summNeg = summNeg + arr[i];
    }
    System.Console.WriteLine("Сумма положительных чисел в массиве: " + summPos);
    System.Console.WriteLine("Сумма отрицательных чисел в массиве: " + summNeg);
}
*/

  void PrintArray(int[] arr1)
  {
    for (int i = 0; i < arr1.Length; i++)
    {
        System.Console.Write(arr1[i] + " ");
    }
  }

int SumPositiv(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0)
    {
      sum = array[i] + sum;
    }
  }
  return sum;
}


int SumNegativ(int[] array1)
{
  int sum = 0;
  for (int i = 0; i < array1.Length; i++)
  {
    if(array1[i] < 0)
    {
      sum = array1[i] + sum;
    }
  }
  return sum;
}

int[] userArray = GetRnd(12, -9, 9);
PrintArray(userArray);

int positiv = SumPositiv(userArray);

int negativ = SumNegativ(userArray);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма положительных равна: {positiv}  Сумма отрицательных равна: {negativ}");