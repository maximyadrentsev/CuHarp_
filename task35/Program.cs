/*
Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значение которых лежат в отрезке [10, 99].
Пример для массива из 5, а не 123 элементов. В своем решение сделать 123.
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/ 


Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 1000);
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


void FineNambers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 10 && arr[i] < 100) count++;
    }
    System.Console.Write("Сумма чисел в массиве:" + count);
}

int[] ArrayA = GetRnd(13);
PrintArray(ArrayA);
System.Console.Write("-->");
FineNambers(ArrayA);