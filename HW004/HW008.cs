/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.*/


int num = int.Parse(Console.ReadLine());
Console.WriteLine("------------");
int i = 1;
//int i = num* (-1);
if (num < 0)
{
    i = -1;
    while (i > num)
    {
        Console.WriteLine(i);
        i--;
    }
}

while (i <= num)
{
    Console.WriteLine(i);
    i++;
}
