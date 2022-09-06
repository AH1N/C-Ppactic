/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/ 


void Coordinates3D(double p1, double p2, double p3, double t1, double t2, double t3)
{
    
    System.Console.WriteLine(Math.Round((Math.Sqrt(Math.Pow(p1-t1, 2) + Math.Pow(p2-t2, 2) + Math.Pow(p3 - t3, 2))),2));
}

Coordinates3D(3,6,8,2,1,-7);
Coordinates3D(7,-5, 0, 1,-1,9);

