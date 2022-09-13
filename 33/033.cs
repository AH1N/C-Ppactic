/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 

Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да

Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/



// int size =Convert.ToInt32(Console.ReadLine());


// int[] arr= new int[size];
// for (int i = 0; i < size; i++)
// {
//     arr[i] = new Random().Next(-9,10);

// }

// System.Console.WriteLine(String.Join(" ,", arr));
// for(int i = 0; i < size; i++){
//     arr[i] *= (-1);
// }

// System.Console.WriteLine(String.Join(" ,", arr));

/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да*/


// int size = Convert.ToInt32(Console.ReadLine());
// int num  = Convert.ToInt32(Console.ReadLine());

// int[] arr= new int[size];
// for (int i = 0; i < size; i++)
// {
//     arr[i] = new Random().Next(-9,10);
    
// }

// System.Console.WriteLine(String.Join(" ,", arr));

// int count = 0;
// for (int i = 0; i < size; i++)
// {
//     if(arr[i] == num) 
//     {
//         count = 1 ;
//         break;
//     }
//     else count = 0;
// }

// if(count == 1) System.Console.WriteLine(num + "присутствует в массиве" + " " + (String.Join(" ,", arr)));
// else System.Console.WriteLine(num + " НЕ присутствует в массиве" + (String.Join(" ,", arr)));


/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/


// int size = Convert.ToInt32(Console.ReadLine());
// int num  = Convert.ToInt32(Console.ReadLine());

// int[] arr= new int[size];
// for (int i = 0; i < size; i++)
// {
//     arr[i] = new Random().Next(1,122);
    
// }

// System.Console.WriteLine(String.Join(" ,", arr));
// int count = 0;

// for (int i = 0; i < size; i++)
// {
//     if (arr[i] >= 10 && arr[i] <= 99)
//     {
//         count++;
//     }
// }

// Console.WriteLine(count);
