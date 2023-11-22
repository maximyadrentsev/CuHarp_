/*
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/ 

Console.Clear();

int[,] GetDarrey(int rows, int colomn)
{
    int[,] array = new int[rows, colomn];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomn; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int[,] SwapRows(int[,] arr)
{
    if(arr.GetLength(0) != arr.GetLength(1))
    {
    System.Console.Write("Заменить строки и столбцы невозможно.");
    return arr;
    }

    int[,] result = new int[arr.GetLength(0), arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[i, j] = arr[j, i];
        }
    }
    return result;
}

void Print2Darrey(int[,] arr)
{
    System.Console.Write("[ ]" + "\t");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        System.Console.Write($"[{j}] \t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
         System.Console.Write($"[{i}] \t");
         for (int j = 0; j < arr.GetLength(1); j++)
         {
            System.Console.Write(" " + arr[i, j] + "\t");
         }
         System.Console.WriteLine();
    }
}


int[,] randomArrey = GetDarrey(3, 3);
Print2Darrey(randomArrey);
int[,] swapRows = SwapRows(randomArrey);
System.Console.WriteLine();
Print2Darrey(swapRows);
