/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int rows = new Random().Next(2, 4);
int columns = rows;

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


// int[,] ProizvedenieMatrix(int kostYl, int[,] arrayA, int[,] arrayB)
// {
//     int rez = 0;
//     int rows = arrayA.GetLength(0);
//     int columns = arrayA.GetLength(1);
//     int[,] rezMartix = new int[rows, columns];
//     int iteration = 0;
//     while (iteration < rows*columns)
//     {
//         iteration++;
//         for (int i = 0; i < arrayA.GetLength(0) - 1; i++)
//         {
//             for (int j = 0; j < arrayA.GetLength(1) - 1; j++)
//             {

//                 System.Console.WriteLine(iteration);
//                 rez = arrayA[i, j] * arrayB[j, i] + arrayA[i, j + 1] * arrayB[j, i + 1];
//                 System.Console.WriteLine(rez);
//                 rezMartix[i, j] = rez;
//                 rez = 0;

//             }
//         }
//     }
//     return rezMartix;
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



void ProizvedenieMatrix(int[,] arrayA, int[,] arrayB, int[,] resMatrix)
{
  for (int i = 0; i < resMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < arrayA.GetLength(1); k++)
      {
        sum += arrayA[i,k] * arrayB[k,j];
      }
      resMatrix[i,j] = sum;
    }
  }
}



int[,] firstMatrix = FillMatrix(rows, columns);
System.Console.WriteLine("Это первая матрица");
PrintArr(firstMatrix);
System.Console.WriteLine();
System.Console.WriteLine("Это вторая матрица");
int[,] secondMatrix = FillMatrix(rows, columns);
PrintArr(secondMatrix);

System.Console.WriteLine("а это произседение");
int[,] rezMartix = new int[rows, columns];

ProizvedenieMatrix(firstMatrix,secondMatrix,rezMartix);

// int[,] rezMatrix = ProizvedenieMatrix(rows, firstMatrix, secondMatrix);

PrintArr(rezMartix);


