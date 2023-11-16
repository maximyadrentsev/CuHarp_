/*
Напишите программу, которая находит сумму элементов с нечетными индексами
 в одномерном массиве целых чисел и выводит результат на экран.
Программа должна иметь метод SumOddElements, 
который принимает массив целых чисел и возвращает сумму элементов с нечетными индексами в массиве.
Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".
Аргументы, передаваемые в метод/функцию:
*/ 


Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] arr1)
  {
    for (int i = 0; i < arr1.Length; i++)
    {
        System.Console.Write(arr1[i] + " ");
    }
  }

void SumNegIndex(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if(i % 2 != 0)
       {
        summ = summ + arr[i];
       }
    }
    System.Console.WriteLine(summ);
}

int[] array = GetRnd(10);
PrintArray(array);
System.Console.WriteLine();
SumNegIndex(array);