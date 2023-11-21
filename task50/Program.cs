/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

например задан массив
 1 4 7 2
 5 9 2 3
 8 4 2 4
 1 и 2 -> 2
 1 и 7 -> такого числа в массиве нет
*/ 

Console.Clear();

int[,] Get2Darrey(int rows, int colomn)
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

void PoiskElements(int[,] arr, int rows, int colomn)
{
    int iskomoe = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (rows == i && colomn == j)
            {
                iskomoe = arr[i, j];
                break;
            }
        }
    }


System.Console.WriteLine();
System.Console.WriteLine($"{rows} и {colomn} -> {iskomoe}");
}
int rowsMassiva = 5;
int colomnMassiva = 5;

int[,] arrayPoisk = Get2Darrey(rowsMassiva, colomnMassiva);
Print2Darrey(arrayPoisk);
System.Console.WriteLine();
System.Console.Write("Введите строку для поиска: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите столбец для поиска: ");
int colomn = Convert.ToInt32(Console.ReadLine());

if(rows >= rowsMassiva || colomn >= colomnMassiva)
{
    System.Console.WriteLine();
    System.Console.WriteLine($"{rows} и {colomn} -> Такого числа в массиве нет.");
}
else
{
    PoiskElements(arrayPoisk, rows, colomn);
}