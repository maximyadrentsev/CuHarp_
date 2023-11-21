/*
Напишите программу, которая будет создавать копию заданного одномерного массива
с помощью элементарного копирования.
*/ 

Console.Clear();

int[] GetRandArray(int size, int start, int end)
{
    int[] arrey = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrey[i] = new Random().Next(start, end + 1);
    }
    return arrey;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
         System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.Write(" ");
}


System.Console.Write("Введите размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите минемальное значение: ");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение: ");
int userEnd = Convert.ToInt32(Console.ReadLine());
int[] userArrey = GetRandArray(userSize, userStart, userEnd);
PrintArray(userArrey);

int[] CoppyArrey(int[] arrey)
{
    int[] newArrey = new int[arrey.Length];
    for (int i = 0; i < arrey.Length; i++)
    {
        newArrey[i] = arrey[i];
    }
    return newArrey;
}

PrintArray(CoppyArrey(userArrey));