/*Задача 68: Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());


    int AkkermanHowItWorks(int m, int n){
         if (m == 0) return (n+1);
         if (n == 0) return AkkermanHowItWorks(m-1,1);
         
         return AkkermanHowItWorks(m-1,AkkermanHowItWorks(m,n-1));
    }

System.Console.WriteLine(AkkermanHowItWorks(M,N));

