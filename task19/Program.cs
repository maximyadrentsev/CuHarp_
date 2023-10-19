/*
Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и False в следующей строке.
Для остальных чисел вернуть True или False.
14212 -> False
12821 -> True
234322 -> Число не пятизначное
*/ 


Console.Clear();

/*System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int n1 = number / 10000;
//System.Console.WriteLine(n1);
int n2 = number/ 1000 % 10;
//System.Console.WriteLine(n2);
int n4 = number /10 % 10;
//System.Console.WriteLine(n4);
int n5 = number % 10;
//System.Console.WriteLine(n5);
if (number >=10000 & number <= 99999)
{
if(n2 == n4 & n1 == n5)
    {
        System.Console.Write("Да ");
    }
    else
     System.Console.Write("Нет ");
    
}
else
{
    System.Console.WriteLine("Не пятизначное число ");
}
*/
System.Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int rewnumber = 0;

for (int i = number; i > 0; i = i / 10)
{
    rewnumber = rewnumber * 10 + i % 10;
}
if (number == rewnumber)
{
    System.Console.WriteLine("ДА");
}
else
{
    System.Console.WriteLine("Нет");
}