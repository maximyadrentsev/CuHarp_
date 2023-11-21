/* 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
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
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
         array[i] = new Random().Next(A, B + 1);
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

 int SumOddElements(int[] arrey)
{
    int result = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i] > 0) result++;

    }
    return result;
}



int[] getarr = GetArray(number, userA, userB);
PrintArray(getarr);
System.Console.WriteLine();
int sumElements = SumOddElements(getarr);
System.Console.Write($"Количество чисел больше ноля {sumElements}");
