/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет

32679 -> 6*/ 

int num2 = Convert.ToInt32(Console.ReadLine());

if(num2 / 100 == 0) {
    Console.WriteLine("ВСЁ ПРОПАЛО, НЕТ ТРЕТЬЕЙ ЦИФРЫ");
}
else{
    Console.WriteLine(num2 % 10);
}
Console.WriteLine("=============================================");


string num3 = Console.ReadLine();
if(num3.Length < 3) Console.WriteLine("ВСЁ ПРОПАЛО, НЕТ ТРЕТЬЕЙ ЦИФРЫ");
else Console.WriteLine(num3[2]);

