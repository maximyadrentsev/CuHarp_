/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 1000)
{
    System.Console.WriteLine("Error");
}
else
{
    number = (number / 10 % 10); // делим на десять чтобы убрать первую цифру числа, % показываем деление с остатком показываем остаток как второе число
    System.Console.WriteLine("вторая цифра " + number);
}