/* 24  Дано А, 
 необходимо найти сумму чисел от 1 до А*/

/*
int a = Convert.ToInt32(Console.ReadLine());
int res = 0;
for (int i = 1; i <= a; i++)
{
    res = res + i;
}

Console.WriteLine($"сумма от 1 до {a} - - - > {res}");
*/
/* 24 - методами  Дано А, 
 необходимо найти сумму чисел от 1 до А*/


/*
System.Console.WriteLine("введи число");

int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(ElCalcul(num));

int ElCalcul(int e)
{
    int result = 0;
    for (int i = 1; i <= e; i++)
    {
        result += i;

    }
    return result;
}

ElCalcul(5);
*/


/*
Задача 26:
Принимает число, отдает сколько в нем чисел
*/

// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(GetKoli4estvo(number));
// int GetKoli4estvo(int num)
// {
//     int count = 0;
//     while(num > 0){
//         count++;
//         num /= 10;
//     }
//     return count;

// }


/*
Задача 28:
Принимает число N, отдает произведение от 1 до N
*/

// System.Console.WriteLine("ВВЕДИТЕ ЧИСЛО");

// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Faktorial(number));

// int Faktorial(int num){
//     int res = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         res *= i;
//     }
//     return res;
// }

/*
Задача 30:
Вывести массив из N элементов, заполненный 0 и 1 в случайном порядкед;
*/

//int [] arr = Array.Empty;

int[] FillArray(int size){
    int[] arr= new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(2); //Next(5) => все от 0 до 4
    }
    return arr;
}

int[] resArray = FillArray(8);

System.Console.WriteLine($"resArray ---> [{String.Join(" ,", resArray)}]");



