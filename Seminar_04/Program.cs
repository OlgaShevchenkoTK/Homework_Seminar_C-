// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int PowNum (int num1, int num2)
{
    int powerNum = 1;
    
    for(int i = 1; i <= num2; i++)
    {
        powerNum = powerNum * num1;        
    }
    return powerNum;
}

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A number {num1} in a power {num2} is: {PowNum(num1, num2)}");
*/
//-------------------------------------------

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int num)
{
    int sum = 0;
    int i = 0;
    while(num > 0)
    {
        i++;
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A sum of digits a number {num} is: {SumDigits(num)}");

//--------------------------------------------

// Задача 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
int[] CreateArray(int m)
{
    int[] array = new int[m];

    for(int i=0; i < m; i++)
    {
        Console.Write("Input argument for array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    return array;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input size of your array: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(m);
PrintArray(myArray);
*/