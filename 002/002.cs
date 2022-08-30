/*Напишите программу, которая на вход принимает два числа и проверяет, являетсяли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/

double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());

if ( a / b == b){
    Console.WriteLine("Число " + a + "является квадратом числа" + b);
}
else{
   Console.WriteLine("Число " + a + " не является квадратом числа" + b); 
}