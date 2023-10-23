/*
Задача 29: Напишите программу, которой пользователь задает размер массива и диапозон в массиве. Выводит ее на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.Clear();
System.Console.WriteLine("Введите длину массива: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минемальное число массива: ");
int userA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное число массива: ");
int userB = Convert.ToInt32(Console.ReadLine());


int[] GetArray(int size, int A, int B)
{
    int[] array = new int [size];// ={1, 0, 1, 0, } можна указать массив после равно
    for (int i = 0; i < size; i++)
    {
        
        array[i] = new Random().Next(A, B + 1);
    }
    return array;
}
void PrintArray(int[] arr)
{
    Console.ForegroundColor=ConsoleColor.Green; //задает цвет терминала
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
        {
            System.Console.Write(", ");
        }
        else
        {
            System.Console.Write(".");
        }
    }
    System.Console.Write("]");
    Console.ResetColor(); //отменяет команду цвета терминала
}


int[] userArray = GetArray(number, userA, userB);
PrintArray(userArray);

