/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/


double[,] matrix = new double[3,4]; 

Random x = new Random(); // Это подглядел (объявление переменной для генерации чисел) - Надо спросить как работает

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++) 
    {
        matrix[i,j] =  Convert.ToDouble(x.Next(-100, 100)/10.0);
        System.Console.Write(matrix[i,j] + "\t");
    }
    System.Console.WriteLine();
}

