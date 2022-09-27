/*из имеющегося массива достаёт четные и создаёт массив из четных*/

int size = new Random().Next(5,11);

int[] array = new int[size];
int n = 0;
for (int i = 0; i <= size-1; i++)
{
    array[i] = new Random().Next(0,11);
    System.Console.Write(array[i] + " ");
   
    if(array[i] % 2 == 0)
    {
        n++;
    }      
}
System.Console.WriteLine();
System.Console.WriteLine("Исходный массив");  


int[] tmpArray = new int[n];
int k = -1;
for (int i = 0; i < size - 1; i++)
{    
    if(array[i] % 2 == 0)
    {
        k++;
        tmpArray[k] = array[i];
        System.Console.Write(tmpArray[k] + " ");     
    }   
}
System.Console.WriteLine();  
System.Console.WriteLine("Новый массив");  

