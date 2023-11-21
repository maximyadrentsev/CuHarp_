/* 
Задаийте двухмерный массив из целых чисел. Найдите среднеарефметическое
элемента в каждом столбце.

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

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write("\t" + "\t" + "\t" + "\t" + "\t");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void SredAref(int[,] arr)
{
    double sredAref = 0;
    double summ = 0;
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            summ += arr[i, j];
        }
        sredAref = summ / arr.GetLength(0);
        System.Console.Write(Math.Round(sredAref, 2) + "\t");
        summ = 0;
        sredAref = 0;
    }
}

int[,] arrayRnd = Get2Darrey(4, 4);
PrintMatrix(arrayRnd);
SredAref(arrayRnd);