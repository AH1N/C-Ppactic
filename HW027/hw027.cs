/*Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/



int number =Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(GetSumDigit(number));

 int GetSumDigit(int num){
    
    int result = 0;
    string strNum = Convert.ToString(num);
   
    for(int i = 0; i < strNum.Length; i++){
        result = result + (num % 10); 
        num = num / 10;     
    }      
    return result;
 }