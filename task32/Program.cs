/*
Напишите программу замена элементов массиваж:
полложительные элементы замените на отрицательные, 
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/


Console.Clear();

int[] GetRnd(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
       array[i] = new Random().Next(min, max + 1);
    }
    return array;
    System.Console.Write(array + " ");
}

void PrintArray(int[] arr1)
  {
    for (int i = 0; i < arr1.Length; i++)
    {
        System.Console.Write(arr1[i] + "\t"); // \t - табуляция 
    }
  }

int[] ChangeArray(int[] arr)// если в методе после значения стоит []. Значит метод должен вернуть нам массив.
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
        
    return arr;
}

int[] arr = GetRnd(10, -20, 20);
PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine("Перевернутый массив: ");
int[] arr2 = ChangeArray(arr);
PrintArray(arr2);