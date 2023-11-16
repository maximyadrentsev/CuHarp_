/* 
Напишите программу, которая подсчитывает количество четных элементов в массиве
целых положительных трехзначных чисел и выводит результат на экран.
Программа должна иметь метод CountEvenElements, 
который принимает массив целых положительных трехзначных чисел и возвращает количество четных элементов в массиве.
Программа должна иметь метод PrintArray, который выводит элементы массива на экран.
При выводе элементы массива должны быть разделены символом табуляции "\t".
Если аргументы командной строки не переданы, программа использует массив по умолчанию,
который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.
*/ 


Console.Clear();

int[] CountEventElements(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        //array[i] = new.Random().Next(min, max);
        array[i] = Convert.ToInt32(Console.Read());
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


void CountPos(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) count++;
    }
    System.Console.WriteLine(count);
}

int[] array = CountEventElements(10);
PrintArray(array);
System.Console.WriteLine();
CountPos(array);
int[] arrayTwo = {100, 102, 105, 166, 283, 764, 300, 499, 133};
PrintArray(arrayTwo);

