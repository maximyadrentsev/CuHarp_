/*
Напишите программу, которая на входе принимает одно число (N), а на выходе показывает все целые числа в промежутке от

4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4''
2 -> "-2, -1, 0, 1, 2"
*/
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int N = -number;
while(N < number + 1)
{
    System.Console.Write(N + " " );
    N = N + 1;
}