/*
Задайте массив. Напишите программу,
которая определяет, присутствует ли заданное число в 
массиве
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да 
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
}

void PrintArray(int[] arr1)
  {
    for (int i = 0; i < arr1.Length; i++)
    {
        System.Console.Write(arr1[i] + " ");
    }
  }

bool IsExist(int[] array, int target)
{
    foreach (int element in array)
    {
        if (element == target) return true;
        if (element * -1 == target) return true;
    }
    return false;
}

System.Console.WriteLine("Задайте цифру: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] ArrayE = GetRnd(10);
PrintArray(ArrayE);
bool Pravda = IsExist(ArrayE, number);
System.Console.WriteLine("-->"  + Pravda); 

