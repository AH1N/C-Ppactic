/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/



// int[,] arr = new int[new Random().Next(2,5),new Random().Next(2,5)];

// for(int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i,j] = new Random().Next(11);
//     }
// }

// System.Console.WriteLine(arr.GetLength(0));
// System.Console.WriteLine(arr.GetLength(1));

// System.Console.WriteLine("ВВЕДИТЕ СТРОКУ ЭЛЕМЕНТА");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("ВВЕДИТЕ СОЛБЕЦ ЭЛЕМЕНТА");
// int n = Convert.ToInt32(Console.ReadLine());

// if(m <= arr.GetLength(0)-1 && n <= arr.GetLength(1)-1) System.Console.WriteLine(arr[m,n]);
// else System.Console.WriteLine("НЕТ ТАКОГО ЭЛЕМЕНТА");



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


void ChecElenent(int[,] array)
{   
    System.Console.WriteLine("ВВЕДИТЕ СТРОКУ ЭЛЕМЕНТА");
    int m = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("ВВЕДИТЕ СОЛБЕЦ ЭЛЕМЕНТА");
    int n = Convert.ToInt32(Console.ReadLine());
    if(m <= array.GetLength(0)-1 && n <= array.GetLength(1)-1) System.Console.WriteLine($" ВОТ ЭТОТ ЭЛЕМЕНТ ---> {array[m,n]} ");
    else System.Console.WriteLine("НЕТ ТАКОГО ЭЛЕМЕНТА");
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

ChecElenent(rezArray);

