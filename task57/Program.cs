/*
Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию отом,
сколька раз встречается элемент входных данных.
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

int[,] testArray = GetDarrey(5, 5);

for (int i = 0; i < testArray.GetLength(0); i++)
{
    for (int j = 0; j < testArray.GetLength(1); j++)
    {
        System.Console.Write(testArray[i, j] + " ");
    }
    System.Console.WriteLine();
}

void PrintElementsCount(int[,] arr)
{
    
    List<int> list = new List<int>();
    foreach (int item in arr)
    {
       if (!list.Contains(item))
       {
        int count = 0;
        foreach (int checkitem in arr)
        {
            if (item == checkitem) count++;
        }
        System.Console.WriteLine(item + " встречается " + count + " раз ");
       }
       list.Add(item);
    }
    
    
}

PrintElementsCount(testArray);


