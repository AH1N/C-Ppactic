/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ ВТОРОЕ ЧИСЛО");
double num2 = double.Parse(Console.ReadLine());
double min,max;

if(num1 > num2) {
    max = num1;
    min = num2;   
}
else {
    max = num2;
    min = num1;
}

Console.WriteLine($" число {max} больше числа {min} "); 
