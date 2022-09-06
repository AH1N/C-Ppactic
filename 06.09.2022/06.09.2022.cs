int Calculate(int a, int b){
    int result = a + b;
    return result;
}

Console.WriteLine(Calculate(4, 5));

Console.WriteLine("============================================");


void VoidCalculate(int a, int b){
    int result = a + b;
    //Console.WriteLine(result);
    System.Console.WriteLine("Hello World");
}

VoidCalculate(4, 5);

Console.WriteLine("============================================");
int [] arrayTest = {1,2,3,4,5,6,7,8,9,0};

void PrintArray(int [] array) {
    for (int i = 0; i< arrayTest.Length; i++)
    {
        Console.Write(arrayTest[i] + " ");
    }
}

PrintArray(arrayTest);