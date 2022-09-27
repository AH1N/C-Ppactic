/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка*/ 



int rows = new Random().Next(2,5);
int columns = rows;

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


void SumColumn(int[,] array)
{   
    double sum = 0;
    double min = rows*10;
    int indexRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];    
        }
        if(sum < min) 
        {
            min = sum;
            indexRow = i;
        }
        System.Console.WriteLine();
        System.Console.WriteLine($" сумма в {i} строке = {sum} ДЛЯ ПРОВЕРКИ мин = {min}");
        sum = 0;   
    } 
    System.Console.WriteLine($" {indexRow} строка ---- ОТВЕТ");  
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

SumColumn(rezArray);
