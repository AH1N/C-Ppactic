/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/ 

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if(M > N)
{
    System.Console.WriteLine("ЕРЕСЬ");
    return;
}

int PrintNumbers(int start, int end)
{
    
    //Базовый
    if(start == end) return start;
    // рекурсия
    return (sum + start + PrintNumbers(start +1, end));
}

System.Console.WriteLine(PrintNumbers(M,N));