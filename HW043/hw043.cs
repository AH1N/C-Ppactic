/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * (b2-b1)/(k1-k2) + b1, y = k2 * (b2-b1)/(k1-k2) + b2; значения b1, k1, b2 и k2 
задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

float k1 = 5;
float b1 = 2;

float k2 = 9;
float b2 = 4;



if((k2*((b2-b1)/(k1-k2)) + b2) == (k1*((b2-b1)/(k1-k2)) + b1))
{
    Console.WriteLine($"({(b2-b1)/(k1-k2)} . {k2*((b2-b1)/(k1-k2)) + b2})");
}
else System.Console.WriteLine("ПРЯМЫЕ ПАРАЛЕЛЬНЫ");

   






 
 

