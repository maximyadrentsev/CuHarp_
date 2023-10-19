/* Внутри класса Answer напишите метод CompareNumbers
который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 ==0)
{
    System.Console.WriteLine("Число четное ");
}
else 
{
    System.Console.WriteLine("Число не четное ");
}