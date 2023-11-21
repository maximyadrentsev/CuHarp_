/*
Задайте двумерный массив размером MxN, 
заполненый случайными вещественными числами.
*/


double[,] Get2Darrey(int row, int col)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 10) + new Random().NextDouble();
        }
    }
    return array;
}

void Print2Darrey(double[,] arr)
{
    System.Console.Write("[ ] \t");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
       System.Console.Write($"[{j}]" + "\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            System.Console.Write($"[{i}]" + "\t");
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                System.Console.Write(Math.Round(arr[i, j], 2) + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
}

double[,] user2Darray = Get2Darrey(4, 4);
Print2Darrey(user2Darray);

