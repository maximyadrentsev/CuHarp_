/*
Напишите программу, которая выводит массив из 
8 элементов, заполненый нулями и единицами
в случайном порядке.
*/ 

Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];// ={1, 0, 1, 0, } можна указать массив после равно
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}
System.Console.WriteLine("Задать размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] userArray = GetRnd(userSize);
PrintArray(userArray);
