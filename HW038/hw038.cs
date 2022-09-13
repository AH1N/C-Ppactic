/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/ 


System.Console.WriteLine("ВВЕДИТЕ РАЗМЕР МАССИВА");
int size = Convert.ToInt32(Console.ReadLine());

double max = 0;
double min = 20;

double[] arr= new double[size];
for (int i = 0; i < size; i++)
{
    arr[i] = new Random().Next(0,20);
    if(arr[i] > max) max = arr[i];
    if(arr[i]<min) min = arr[i];  
}

System.Console.WriteLine(String.Join(" ,", arr));

System.Console.WriteLine($"{max} ЭТО МАКСИМУМ");
System.Console.WriteLine($"{min} ЭТО МИНИМУМ ");
System.Console.WriteLine($"{max-min} ЭТО РАЗНИЦА");

