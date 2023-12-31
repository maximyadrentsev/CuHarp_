﻿/*
Найдите произведение пар чисел в одномерном массиве.
Парой считаются первый и последний элемент,
второй и предпоследний элемент и т.д.
Результата запишите в новом массиве.
*/

Console.Clear();

int[] CreateArray(int size, int min, int max)
{
    var random = new Random();

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}

void Output(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

int[] MultArray(int[] array)
{
    int[] result = new int[array.Length - array.Length / 2];
    int temp = 0;
    for (int i = 0; i < array.Length - array.Length / 2; i++)
    {
        if (i == array.Length - 1 - i)
        {
            result[i] = array[i];
            continue;// заканчивает цикл
        }
        temp = array[i] * array[array.Length - 1 - i];// первый элемент массив умножается на последний элемент массива 
        result[i] = temp;
    }
    return result;
}

int[] array = CreateArray(7, -1, 5);
Output(array);
System.Console.WriteLine();
int[] array2 = MultArray(array);
Output(array2);