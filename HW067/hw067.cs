/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/ 


int M = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    //Базовый
    if(start == end) return start.ToString();
    // рекурсия

    return (start + " ," + PrintNumbers(start -1, end));
}

System.Console.WriteLine(PrintNumbers(M, 1));