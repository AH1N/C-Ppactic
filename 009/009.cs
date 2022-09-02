//случайное число из отрезка 10,99 и показывает наибольшее
int num = Convert.ToInt32(Console.Readline());

int FirstNum = num / 10;
int SecondNum = num % 10;

int max = FirstNum;
if(SecondNum > max) SecondNum = max;
