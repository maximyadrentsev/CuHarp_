/* 
Напишите программу, которая принемает на вход трехзначное число и на выходе показывает последнию цифру этого числа.

456 ->
782 ->
918 ->
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    System.Console.WriteLine("Error");
}
else
{
    number = (number % 10);
    System.Console.WriteLine("последняя цифра " + number);
}