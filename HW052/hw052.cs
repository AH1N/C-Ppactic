/*Задача 52. Задайте двумерный массив из целых чисел. 

Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


int rows = new Random().Next(2,7);
int columns = new Random().Next(2,7);

int [,] FillMatrix(int m, int n){
    int [,] matrix = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(11);
        }
    }
    return matrix;
}


void MidSumColumn(int[,] array)
{   
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];    
        }
        System.Console.WriteLine($" среднеарифметическое в {j} столбце = {sum/array.GetLength(0)}");
        System.Console.WriteLine();
        sum = 0;
    }   
}


void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] rezArray = FillMatrix(rows, columns);

PrintArr(rezArray);

MidSumColumn(rezArray);
