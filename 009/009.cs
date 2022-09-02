//случайное число из отрезка 10,99 и показывает наибольшее
int num = Convert.ToInt32(Console.ReadLine());

int FirstNum = num / 10;
int SecondNum = num % 10;

int max = FirstNum;
if(SecondNum > max) max = SecondNum;

Console.WriteLine($"{max} это число максимальное");
