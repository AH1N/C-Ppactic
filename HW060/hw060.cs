/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/





int[] FillArray(int m, int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = 10 + i;  
    }
    return array;
}


int [,,] FillCube(int x, int y, int z)
{
    int [] array = FillArray(10, 90);
    int [,,] cube = new int[z,y,z];
    for(int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {   
                int index = 0;
                int tmp = 0;
                index = new Random().Next(0,array.Length);
                cube[i,j,k] = array[index];
                tmp = array[array.Length-1];
                Array.Clear(array, index, 1);
                array[index] = tmp;
                array[array.Length-1] = 0;
                Array.Resize(ref array, array.Length-1);
                System.Console.Write($"{cube[i,j,k]} {(i,j,k)}");
            } 
            System.Console.WriteLine();    
        }
    }
    return cube;
}

FillCube(2,2,2); 



// void PrintArr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

//int [] tempArray = FillArray(10, 90);

// PrintArr(tempArray);


// int[] CreateNewTmpArray(int[] array, int dlinaNovogoMassiva)
// {
//     int [] rezArray = new int[dlinaNovogoMassiva];
//     int i = 0;
//     int index = 0;
//     while(i < dlinaNovogoMassiva)
//     {
//         int tmp = 0;
//         index = new Random().Next(0,array.Length);
//         rezArray[i] = array[index];
//         tmp = array[array.Length-1];
//         Array.Clear(array, index, 1);
//         array[index] = tmp;
//         array[array.Length-1] = 0;
//         Array.Resize(ref array, array.Length-1);
//         i++;   
//     } 
//    return rezArray;        
// }

// PrintArr(CreateNewTmpArray(tempArray, 80));

// int[] FashionUnmazibleSexyRandom(int oT, int dO, int dlinaNovogoMassiva)
// {
//     int [] array = FillArray(oT, dO);
//     // создаём массив из N неповторяющихся элементов
//     int [] rezArray = new int[dlinaNovogoMassiva];
//     int i2 = 0;
//     int index = 0;
//     while(i2 < dlinaNovogoMassiva)
//     {
//         int tmp = 0;
//         index = new Random().Next(0,array.Length);
//         rezArray[i2] = array[index];
//         tmp = array[array.Length-1];
//         Array.Clear(array, index, 1);
//         array[index] = tmp;
//         array[array.Length-1] = 0;
//         Array.Resize(ref array, array.Length-1);
//         i2++;   
//     } 
//    return rezArray;        
// }

//PrintArr(FashionUnmazibleSexyRandom(10, 80, 80));


