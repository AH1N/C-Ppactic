/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/


int rows = new Random().Next(2, 7);
int columns = new Random().Next(2, 7);

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}

int[,] SortRowsInArrayMaxElementToMinElement(int[,] array)
{
    int tmp = 0;
    int iteration = 0;
    while (iteration < array.GetLength(1))
    {
        iteration++;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {

                if (array[i, j] < array[i, j + 1])
                {
                    tmp = array[i, j + 1];
                    array[i, j + 1] = array[i, j];
                    array[i, j] = tmp;
                }
            }
        }
    }

    return array;
}


// void MidSumColumn(int[,] array)
// {   
// double sum = 0;
// for (int j = 0; j < array.GetLength(1); j++)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         sum += array[i,j];    
//     }
//     System.Console.WriteLine($" среднеарифметическое в {j} столбце = {sum/array.GetLength(0)}");
//     System.Console.WriteLine();
//     sum = 0;
// }   
// }


void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] rezArray = FillMatrix(rows, columns);
PrintArr(rezArray);
System.Console.WriteLine();
System.Console.WriteLine("А ТЕПЕРЬ ОТСОРТИРОВАННЫЙ МАССИВ");
PrintArr(SortRowsInArrayMaxElementToMinElement(rezArray));



