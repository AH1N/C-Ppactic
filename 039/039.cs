/*Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/


// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[size];

// for(int i = 0; i < size; i++)
// {
//     arr[i] = new Random().Next(11);
//     Console.Write(arr[i] + " ");
// }

// System.Console.WriteLine();

// int[] perArr = new int[size];
// int lasti = size-1;

// for(int i = 0; i < size; i++)
// {
//     perArr[i] = arr[lasti - i];
//     Console.Write(perArr[i] + " ");
// }


/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона
 треугольника меньше суммы двух других сторон.
*/

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());

// bool IsTriangle(int a, int b, int c)
// {
//     return ((a+b>c) && (a+c>b) && (b+c>a));
// }

// System.Console.WriteLine(IsTriangle(a,b,c));



/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/


// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

// arr[0] = 0;
// arr[1] = 1;

// for(int i = 2; i < n; i++)
// {
//     arr[i] = arr[i-1] + arr[i-2];     
// }

// System.Console.WriteLine(String.Join(" ", arr));


int num = 10;

int num1 = 0;

int num2 = 1;

System.Console.WriteLine(num1);
System.Console.WriteLine(num2);

for (int i = 3; i < num; i++)
{
    int nextNum = num1 + num2;
    System.Console.WriteLine(nextNum);

    num1 = num2;
    num2 = nextNum;
}