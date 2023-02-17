// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for(int i=0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

int NumOfEvenNumbers(int[] array, int length)
{
    int count = 0;
    
    for(int i = 0; i < length; i++)
    {        
        if(array[i] % 2 == 0) count++;
    }
    
    return count;
}

Console.Write("Inpun a size array: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);

ShowArray(myArray);

Console.WriteLine(NumOfEvenNumbers(myArray, length));
*/
//-----------------------------------------

// Задача 2. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOfOddNumIndex(int[] myArray)
{
    int sum = 0;
    int count = 0;
    for(int i = 1; i < myArray.Length; i+=2)
    {
        count = i;
        sum = sum + myArray[count];
    }
    
    return sum;
}

Console.Write("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a Min Value of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a Max Value of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, minValue, maxValue);
ShowArray(newArray);

int sum = SumOfOddNumIndex(newArray);
Console.WriteLine($"Sum of odd numbers index is: {sum}");

//-----------------------------------------

// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().Next(minValue, maxValue+1) + new Random().NextDouble(),2);
    }
    
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
}

double DiffMaxNumMinNum(double[] array)
{
    double maxNum = 0;
    double minNum = maxNum;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxNum) maxNum = array[i];
        else
        {
            minNum = array[i];
            if(array[i] < minNum) minNum = array[i];
        }
        
    }
    return maxNum - minNum;    
}

Console.Write("Input a size of array: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min value of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max value of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(length, minValue, maxValue);

ShowArray(myArray);

Console.WriteLine(DiffMaxNumMinNum(myArray));
*/