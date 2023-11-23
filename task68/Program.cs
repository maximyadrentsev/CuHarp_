/*
Задача 68: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/ 

Console.Clear();


static int Ackermann (int n, int m)
{ 
    
    if(n == 0 || m < 0 )
    {
        return (1 + m);
    }   
    if(n < 0 || m == 0)
    {
        return Ackermann (n - 1, 1);
    }    
    if(n < 0 || m < 0) 
    {
        return Ackermann(n - 1, Ackermann(n, m - 1));
    }
                       
                        
                       
}
int resalt = Ackermann(2, 3);
System.Console.WriteLine(resalt);// не смог понять почему выдает ошибку
