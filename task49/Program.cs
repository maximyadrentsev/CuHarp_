/*Задайте двумерный массив. Найдите элементы, у которых
оба индекса четных, и замените эти элементы на их квадраты.
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

int[,] Sqare2DEven(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if(i % 2 == 0 & j % 2 == 0) arr1[i, j]*= arr1[i, j];
        }
    }
    return arr1;
}


int[,] user2Darray = Get2Darrey(3, 4);
Print2Darrey(user2Darray);
System.Console.WriteLine();
int[,] usersqear2D = Sqare2DEven(user2Darray);
Print2Darrey(usersqear2D);
