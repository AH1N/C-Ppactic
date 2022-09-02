/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int num1 = new Random ().Next(100,1000);
Console.WriteLine(num1);
int secondDigit = (num1 / 10) % 10;
Console.WriteLine(secondDigit);
Console.WriteLine("=============================================");

int num2 = Convert.ToInt32(Console.ReadLine());
int twoSecondDigit = (num2 / 10) % 10;
Console.WriteLine(twoSecondDigit);
Console.WriteLine("=============================================");

string num3 = Console.ReadLine();
Console.WriteLine(num3[1]);
