/*Задача 4: Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО");
double num1 = double.Parse(Console.ReadLine());
double max = num1;
Console.WriteLine("ВВЕДИТЕ ВТОРОЕ ЧИСЛО");
double num2 = double.Parse(Console.ReadLine());
if(max < num2){
    max = num2;
}
Console.WriteLine("ВВЕДИТЕ ТРЕТЬЕ ЧИСЛО");
double num3 = double.Parse(Console.ReadLine());
if(max < num3){
    max = num3;
}
Console.WriteLine(max);
