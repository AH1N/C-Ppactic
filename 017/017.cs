/*17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и
 выдаёт номер четверти плоскости, 
в которой находится эта точка. */

/*
System.Console.WriteLine("введите координаты по х");
int x  = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine("введите координаты по y");
int y  = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0) System.Console.WriteLine("I четверть");
else if (x<0 && y>0) System.Console.WriteLine("II четверть");
else if (x<0 && y<0) System.Console.WriteLine("III четверть");
else System.Console.WriteLine("IV четверть");
*/
Console.WriteLine("============================================");
/*Напишите программу, которая по заданному номеру четверти, показывает 
диапазон возможных
 координат точек в этой четверти (x и y).
*/
/*
System.Console.WriteLine("введите номер четверти");
int quater  = Convert.ToInt32(Console.ReadLine());

if (quater == 1) System.Console.WriteLine("x>0, y>0");
else if (quater == 2)  System.Console.WriteLine("(x<0  y>0)");
else if (quater == 3) System.Console.WriteLine("x<0 && y<0");
else if (quater == 4) System.Console.WriteLine("x>0  y<0");
else System.Console.WriteLine("YBXTUJ YT GJKEXBKJCM");
*/
Console.WriteLine("============================================");

/*Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
/*
System.Console.WriteLine("введите координату x1");
double x1  = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("введите координату y1");
double y1  = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("введите координату x2");
double x2  = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("введите координату y1");
double y2  = Convert.ToDouble(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y2-y1, 2));

System.Console.WriteLine(d);
System.Console.WriteLine(Math.Round(d,2));
*/
Console.WriteLine("============================================");
/*
Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/


System.Console.WriteLine("введите конец");
int end  = Convert.ToInt32(Console.ReadLine());

for(int start = 1; start <= end; start++){
    System.Console.WriteLine(Math.Pow(start, 2));
}