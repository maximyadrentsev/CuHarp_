Console.Clear();

/*
double Num(int a) //метод возврашает переменную типа double и принимает итоговую переменную.
{
    double resalt = Math.Pow(a, 3);
    return resalt;
}

double usernum = Num(2);
System.Console.WriteLine(usernum);
*/

/*
int Num1()   // метод не принемает данные от пользователя но вернет результат(данные вводятся непосредственно в самом методе)
{
    int a1 = 5;
    int result = a1 + a1;
    return result;
}

int usera = Num1();
System.Console.WriteLine(usera);

*/
/*
void Num2(int a2) // метод войд не возвращает переменную
{
    int resalt = a2 + a2;
    System.Console.WriteLine(resalt);
}

Num2(10); 
*/

/*
напишите программу, которая принемает на вход число (А)
и выдает сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/


int Numbers(int namb)
{
    int summ = 0;
    for (int i = 0; i <= namb ; i++)
    {
        summ = summ + i;
    }
    return summ;
}

System.Console.WriteLine("Введите число ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int resalt = Numbers(userNumber);
System.Console.WriteLine($"Сумма чисел от 1 до {userNumber} = {resalt}");