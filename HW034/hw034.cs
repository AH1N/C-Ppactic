/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/ 

System.Console.WriteLine("ПЕРВЫЙ ВАРИАНТ - ПОЧЕМУТО НЕ РАБОТАЕТ");

// int number =Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(String.Join(" ,", FillArray(number)));
// int[] maSSive = FillArray(number);
// System.Console.WriteLine($" ВОТ СТОЛЬКО ЧЕТНЫХ ЧИСЕЛ ------>  {Check2Array(maSSive)}");


// int[] FillArray(int size){
//     int[] arr= new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(100,1000);
//     }
//     return arr;  
// }

// int Check2Array(int[] arrr){

//     int count = 0;
//     for (int i = 0; i < arrr.Length; i++)
//     {
//         System.Console.WriteLine(arrr[i]); // ОТКУДА БИРУТСЯ ЭТИ ЧИСЛА
//         if (arrr[i] % 2 == 0)
//         {   
//             count +=1;
//         }
//     }
//     return count;
// }
System.Console.WriteLine("==========================================");
System.Console.WriteLine("");
System.Console.WriteLine("ВТОРОЙ ВАРИАНТ");

int size = Convert.ToInt32(Console.ReadLine());


int[] arr= new int[size];
for (int i = 0; i < size; i++)
{
    arr[i] = new Random().Next(100,1000);  
}

System.Console.WriteLine(String.Join(" ,", arr));

int count = 0;
for (int i = 0; i < size; i++)
{
    if (arr[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine(count);




