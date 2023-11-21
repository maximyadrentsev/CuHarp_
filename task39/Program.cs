/*
Напишите программу, которая переварачивает одномерный массив.
*/

Console.Clear();

int GetRnd(int size)
{
    var random = new Random();

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(0, 10);
    }
    return arr;
}

int Print(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1);
        System.Console.Write(arr[i]);
        if (i < arr.Length -1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("]");
    Console.ResetColor();
}

void Reverse(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        temp = array[array.Length - 1 -i];
        array[array.Length - 1 -i] = array[i];
        array[i] = temp;
    }
}

int size = Print("Задайте размер массива: ");
int[] userarrey = GetRnd(size);
PrintArray(userarrey);
System.Console.WriteLine();
Reverse(userarrey);
PrintArray(userarrey);
