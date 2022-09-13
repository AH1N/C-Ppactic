/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
чисел равна 29, сумма отрицательных равна -20.
*/

int size = Convert.ToInt32(Console.ReadLine());
//int num  = Convert.ToInt32(Console.ReadLine());

int[] arr= new int[size];
for (int i = 0; i < size; i++)
{
    arr[i] = new Random().Next(-9,10);
    
}

System.Console.WriteLine(String.Join(" ,", arr));
int countP = 0;
int countN = 0;

for (int i = 0; i < size; i++)
{
    if (arr[i] > 0) countP += arr[i];
    else countN += arr[i];
}


Console.WriteLine(countP);
System.Console.WriteLine(countN);













