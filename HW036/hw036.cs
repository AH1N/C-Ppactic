/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


System.Console.WriteLine("ВВЕДИТЕ РАЗМЕР МАССИВА");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr= new int[size];
for (int i = 0; i < size; i++)
{
    arr[i] = new Random().Next(1,20);  
}

System.Console.WriteLine(String.Join(" ,", arr));

int count = 0;
for (int i = 1; i < size; i +=2 )
{
    count +=arr[i];
    Console.WriteLine($"{arr[i]} ---- {i}");
    
}

Console.WriteLine(count);
