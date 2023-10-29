/*
Напишите программу замена элементов массиваж:
полложительные элементы замените на отрицательные, 
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/


Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
       array[i] = new Random().Next(-9, 10);
    }
    return array;
    System.Console.Write(array + " ");
}

void PrintArray(int[] arr1)
  {
    for (int i = 0; i < arr1.Length; i++)
    {
        System.Console.Write(arr1[i] + " ");
    }
  }

int[] ChangeArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
        
    return arr;
}

int[] arr = GetRnd(10);
PrintArray(arr);
System.Console.WriteLine();
int[] arr2 = ChangeArray(arr);
PrintArray(arr2);