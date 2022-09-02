/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

int num1 = Convert.ToInt32(Console.ReadLine());
if(num1 > 5 && num1 < 8) Console.WriteLine("да");
else Console.WriteLine("нет");
    


