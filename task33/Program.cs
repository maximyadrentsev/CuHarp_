/*
Задайте массив. Напишите программу,
которая определяет, присутствует ли заданное число в 
массиве
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, -3] -> да 
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
}

void PrintArray(int[] arr1)
  {
    for (int i = 0; i < arr1.Length; i++)
    {
        System.Console.Write(arr1[i] + " ");
    }
  }
/*
void IsExist(int[] array, int target)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == target)
        System.Console.Write($"Число {target} есть в массиве");
        else if (array[i]!= target)
        System.Console.Write($"Числа {target} нет в массиве");
        
    }
}
*/


bool IsExist(int[] array, int target)
{
    bool resalt = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == target)
            resalt = true; // если цикл нашел нам нужное число в массиве то он возвращает true
    }
    return resalt;// если цикл не нашел заданное число то он возращает false
}


int[] ArrayE = GetRnd(10, -9, 9);
PrintArray(ArrayE);
System.Console.WriteLine();
System.Console.WriteLine("Задайте цифру: ");

int number = Convert.ToInt32(Console.ReadLine());
//IsExist(ArrayE, number);

bool result2 = IsExist(ArrayE, number);
System.Console.WriteLine((result2)? $"Число {number} в массиве есть":$"Числа {number} в массиве нет" );
