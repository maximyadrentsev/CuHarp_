/*
1. Напишите программу, которая на входе принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25; b = 5 -> да
a = 2; b = 10 -> нет
a = 9; b = -3 -> да
a = -3; b = 9 -> нет
*/
System.Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 == number2 * number2)
{
    System.Console.WriteLine("да, первое число - это квадрат второго числа");

}
else
{
    System.Console.WriteLine("нет, первое число не является квадратом второго");
}