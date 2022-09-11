/*Задача 29: Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

System.Console.WriteLine("ПЕРВЫЙ ВАРИАНТ");

int number =Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(String.Join(" ,", FillArray(number)));

int[] FillArray(int size){
    int[] arr= new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100); //Next(5) => все от 0 до 4
    }
    return arr;  
}

System.Console.WriteLine("=============================================");
System.Console.WriteLine(" ");
System.Console.WriteLine(" ");

System.Console.WriteLine("ВТОРОЙ ВАРИАНТ");

int size =Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{String.Join(" ,", FillArray1(size))} ------ ВОТ ТАКОЙ МАССИВ ПОЛУЧИЛСЯ");

int[] FillArray1(int size){

    int[] arr= new int[size];
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine($"ВВЕДИТЕ {i} ЭЛЕМЕНТ");
    
        arr[i] = Convert.ToInt32(Console.ReadLine()); //ПОЧЕМУ ТУТ NEW НЕ НАДО ПИСАТЬ??
    }
    return arr;  
}

