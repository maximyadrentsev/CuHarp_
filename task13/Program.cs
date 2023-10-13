/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int resalt = 0;
for (int i = number; i >= 100; i = i / 10) // В команде фор мы принимаем число, сравниваем его если больше 3 х значного делим на 10
{
   resalt = i % 10; 
}
if (number < 100 )
{
     System.Console.WriteLine("Третьей цифры нет ");
}
else 
{
    System.Console.WriteLine("третья цифра числа " + resalt);
}


