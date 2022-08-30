/* Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает последнюю цифру этого числа. 
*/

int num = int.Parse(Console.ReadLine());
num = (num % 10);
Console.WriteLine(num);
