/*
Задайте массив из 12 элементов, заполненый случайными числами
из промежутка [-9, 9]. найдите сумму отрицательных и положительных
элементов массива.
Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/ 


Console.Clear();


int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
       array[i] = new Random().Next(-9, 10);
    }
    return array;
    System.Console.Write(array + " ");
}

void SumArray(int[] arr)
{
    int summPos = 0;
    int summNeg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) summPos = summPos + arr[i];
        else summNeg = summNeg + arr[i];
    }
    System.Console.WriteLine("Сумма положительных чисел в массиве: " + summPos);
    System.Console.WriteLine("Сумма отрицательных чисел в массиве: " + summNeg);
}


  void PrintArray(int[] arr1)
  {
    for (int i = 0; i < arr1.Length; i++)
    {
        System.Console.Write(arr1[i] + " ");
    }
  }

int[] userArray = GetRnd(12);
PrintArray(userArray);
System.Console.WriteLine();
SumArray(userArray);


