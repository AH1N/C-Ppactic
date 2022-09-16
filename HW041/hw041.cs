/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/ 


	

int[] arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

int count = 0;
//System.Console.WriteLine(String.Join(" ", arr));

for(int i = 0;  i < arr.Length;  i++)
{
   if(arr[i] > 0)
   {
    count++;
   } 
}

System.Console.WriteLine(count);