/* Факториал чисел от 1 до N*/

// int Faktorial(int N)
// {
//     if(N == 1) return 1;
//     return (N * Factorial(N-1));
// }


/*Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/


// int N = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {
//     //Базовый
//     if(start == end) return start.ToString();
//     // рекурсия

//     return (start + " ," + PrintNumbers(start +1, end));
// }


/*Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/
// int M = Convert.ToInt32(Console.ReadLine());
// int N = Convert.ToInt32(Console.ReadLine());

// if(M > N)
// {
//     System.Console.WriteLine("ЕРЕСЬ");
//     return;
// }

// string PrintNumbers(int start, int end)
// {
//     //Базовый
//     if(start == end) return start.ToString();
//     // рекурсия

//     return (start + " ," + PrintNumbers(start +1, end));
// }


// System.Console.WriteLine(PrintNumbers(M,N));


/*Задача 67: Напишите программу, которая будет 
принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/
// int num = Convert.ToInt32(System.Console.ReadLine());
// int SummNumber(int num)
// {
//     // База
//     if(num % 10 == 0) return 0;
//     // Рекурсия
//     return (num % 10 + SummNumber(num/10));
// }

// System.Console.WriteLine(SummNumber(num));

/*Задача 69: Напишите программу, 
которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int num = Convert.ToInt32(Console.ReadLine());

int deg = Convert.ToInt32(Console.ReadLine());

int Pow(int num, int power)
{
    if(power == 0) return 1;
    if(power == 1) return num;

    return (num* Pow(num, power - 1));
}

System.Console.WriteLine(Pow(num, deg));