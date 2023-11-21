/*
Не используя рекурсию, выведите первые N чисел Фибоначи.
Первые два числа Фибоначи: 0 и 1.
*/ 

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Fibonachi(int number)
{
    int size = number;
    if (number < 2) size = 2;
    int[] array = new int [size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] arrayOne)
{
    System.Console.Write("Number N = " + arrayOne.Length + ": ");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(" " + arrayOne[i]);
    }
    System.Console.WriteLine();
}

int number = Prompt("Enter number: ");
PrintArray(Fibonachi(number));