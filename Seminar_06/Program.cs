// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
// Вариант с массивом
/*
int[] CreateArray (int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write("Input a number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int CountOfPozitiveNum (int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(length);
ShowArray(myArray);

Console.WriteLine($"{CountOfPozitiveNum (myArray)} ");
*/

// Вариант без массива
/*
int CountOfPozitiveNum()
{
    int num = 0;
    int count = 0;
    do
    {
        Console.Write("Input a number: ");
        num = Convert.ToInt32(Console.ReadLine());
        if(num > 0) count++;
    } while (num != 0);
    
    return count;
}

Console.WriteLine($"{CountOfPozitiveNum()}");
*/
//--------------------------------------

// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PointOfIntersection (double b1, double k1, double b2, double k2)
{
    double pointOrd = (-k2 * b1 + 5 * b2) / (5 - k2);
    double pointAbs = (pointOrd - b1) / k1;
    Console.WriteLine($"Coordinates of the intersection point is ({pointAbs};{pointOrd}) ");
}

Console.Write("Input a value b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a value k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a value b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a value k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

PointOfIntersection(b1, k1, b2, k2);
