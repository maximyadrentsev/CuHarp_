/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int [size];// ={1, 0, 1, 0, } можна указать массив после равно
    for (int i = 0; i < size; i++)
    {
        int A = Convert.ToInt32(Console.ReadLine());
        int B = Convert.ToInt32(Console.ReadLine());
        
        array[i] = new Random().Next(A, B);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

System.Console.WriteLine("Введите длину массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRnd(number);
PrintArray(userArray);
