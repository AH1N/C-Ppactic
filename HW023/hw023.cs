/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

void NumberInCube(int n)
{  
    for(int start = 1; start <= n; start++)
    {
        System.Console.WriteLine(Math.Pow(start, 3));
    }
}

System.Console.WriteLine("введите конец");

NumberInCube(Convert.ToInt32(Console.ReadLine()));
