/**/

// int[,] matrix = new int[3,4];

// System.Console.WriteLine("ВВЕДИТЕ КОЛИЧЕСТВО СТРОК: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("ВВЕДИТЕ КОЛИЧЕСТВО СТОЛБЦОВ: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// //m,n - СТРОКИ СТОЛБЦЫ

// int [,] FillMatrix(int m, int n){
//     int [,] matrix = new int[m,n];
//     for(int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i,j] = new Random().Next(11);
//         }
//     }
//     return matrix;
// }


// void PrintArr(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] rezArray = FillMatrix(rows, columns);

// PrintArr(rezArray);



/*Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

// int[,] matrix = new int[3,4];

// System.Console.WriteLine("ВВЕДИТЕ КОЛИЧЕСТВО СТРОК: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("ВВЕДИТЕ КОЛИЧЕСТВО СТОЛБЦОВ: ");
// int columns = Convert.ToInt32(Console.ReadLine());


// int [,] FillMatrix(int m, int n){
//     int [,] matrix = new int[m,n];
//     for(int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i,j] = i + j;//тут изменение было
//         }
//     }
//     return matrix;
// }


// void PrintArr(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] rezArray = FillMatrix(rows, columns);

// PrintArr(rezArray);



/*Задайте двумерный массив. Найдите элементы, 
у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
*/


// int[,] matrix = new int[3,4];

// System.Console.WriteLine("ВВЕДИТЕ КОЛИЧЕСТВО СТРОК: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("ВВЕДИТЕ КОЛИЧЕСТВО СТОЛБЦОВ: ");
// int columns = Convert.ToInt32(Console.ReadLine());


// int [,] FillMatrix(int m, int n){
//     int [,] matrix = new int[m,n];
//     for(int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i,j] = new Random().Next(10);
//             if(i % 2 == 0 && j % 2 == 0){
//                 matrix[i,j] *= matrix[i,j];
//             }
//         }
//     }
//     return matrix;
// }

// void PrintArr(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] rezArray = FillMatrix(rows, columns);

// PrintArr(rezArray);




/*Найти сумму элементов главной диагоналиюНапример, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

int[,] matrix = new int[3,4];

System.Console.WriteLine("ВВЕДИТЕ КОЛИЧЕСТВО СТРОК: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("ВВЕДИТЕ КОЛИЧЕСТВО СТОЛБЦОВ: ");
int columns = Convert.ToInt32(Console.ReadLine());


int [,] FillMatrix(int m, int n){
    int [,] matrix = new int[m,n];
    
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(10);
        }   
    }
    return matrix;
}

void PrintArr(int[,] array)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
            if(i == j)
            {
                summ += array[i,j];
            }
        }System.Console.WriteLine();
    }    
        System.Console.WriteLine(summ);
}
    


int[,] rezArray = FillMatrix(rows, columns);

PrintArr(rezArray);
