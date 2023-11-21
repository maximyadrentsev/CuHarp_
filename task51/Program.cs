/*
Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонале (с индексом (0,0);(1,1)) и т.д.
*/ 

Console.Clear();

int[,] Get2Darrey(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Print2Darrey(int[,] arr)
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
                System.Console.Write(" " + arr[i, j] + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
}

int ElementsDiagonal(int[,] arr)
{
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       result +=arr[i, i];
    }
    return result;
}

int[,] user2Darray = Get2Darrey(4, 4);
Print2Darrey(user2Darray);
System.Console.WriteLine();
int userDiagonal = ElementsDiagonal(user2Darray);
System.Console.WriteLine(userDiagonal);