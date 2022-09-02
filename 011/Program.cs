/*11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/
int num = new Random ().Next(100,999);
Console.WriteLine(num);

int num2 = num / 100;

int num1 = num % 10;

Console.Write(num2);
Console.Write(num1);


