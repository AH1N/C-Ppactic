/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/ 

Console.WriteLine("ВВЕДИТЕ ПОЛИНДРОМ");

string plndrm = Console.ReadLine();
int kratnost;
//это не четная часть

if(plndrm.Length % 2 != 0){
  
    for (int i = 0; i <= plndrm.Length/2; i++)
    {
        if(plndrm[(plndrm.Length/2)-i] == plndrm[(plndrm.Length/2)+i])
        {

            System.Console.WriteLine($"{plndrm[(plndrm.Length/2)-i]} <---> {plndrm[(plndrm.Length/2)+i]} ");
            System.Console.WriteLine(i);
        }
        else {
            Console.WriteLine("ЭТО НЕ ПОЛИНДРОМ");
            break;
            } 
        
        if (i == plndrm.Length/2-1){Console.WriteLine("ЭТО ПОЛИНДРОМ");};    
    } 
/**/
//это четная часть
}

if(plndrm.Length % 2 == 0)
{
    for (int i = 0; i < plndrm.Length/2; i++){
        if(plndrm[(plndrm.Length/2-1)-i] == plndrm[(plndrm.Length/2)+i])
        {

            System.Console.WriteLine($"{plndrm[(plndrm.Length/2-1)-i]} <---> {plndrm[(plndrm.Length/2)+i]} ");
            System.Console.WriteLine(i);
        }
        else {
            Console.WriteLine("ЭТО НЕ ПОЛИНДРОМ");
            break;
            } 
        
        if (i == plndrm.Length/2-1){Console.WriteLine("ЭТО ПОЛИНДРОМ");};    
    }   
}





