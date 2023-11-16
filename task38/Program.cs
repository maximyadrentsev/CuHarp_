/* 
Напишите программу для работы с массивом вещественных чисел.
*/ 


Console.Clear();

double[] GetDoubleRnd(int size)
{
    
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().NextDouble() + new Random().Next(-99, 99);
    }
    return arr;
}

void PrintDoubleArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(Math.Round(arr[i], 2));
        if(i < arr.Length - 1);
            System.Console.Write(", ");
    }
}

void MinMax(double[] arr)
{
    double min = 0;
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
    }
    System.Console.WriteLine($"Разница между{max} и {min} равна {max - min}");
}

double[] arrayDouble = GetDoubleRnd(5);
PrintDoubleArray(arrayDouble);
MinMax(arrayDouble);
