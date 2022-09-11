/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16*/


Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ВВЕДИТЕ СТЕПЕНЬ");
int stepen = Convert.ToInt32(Console.ReadLine());
 
System.Console.WriteLine(PowNum(num,stepen));

int PowNum(int a, int pow){
    int res = a;
    for(int i = 1; i <= pow-1; i++){
        res = res * a;
    }
    return res;
}
