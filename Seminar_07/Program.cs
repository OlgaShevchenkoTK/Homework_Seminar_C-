// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a number pows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = Math.Round(new Random().Next(minValue, maxValue+1) + new Random().NextDouble(),2);
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/

//==================================================================

//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет
/*

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a possible min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a possible max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i, j] + " ") ;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// void CheckElemBycountex(int[,] array)
// {
//     Console.Write("Input the row number of the element: ");
//     int row = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input the columns number of the element: ");
//     int columns = Convert.ToInt32(Console.ReadLine());

//     if(row > array.GetLength(0) || columns > array.GetLength(1)) 
//         Console.WriteLine("ERROR! There is no such element!");
//     else Console.WriteLine($"Your the element is: {array[row, columns]}");
// }

// int[,] newArray = CreateRandom2dArray();
// Show2dArray(newArray);
// CheckElemBycountex(newArray);

//------------------------

// Либо другой вариант, в зависимости от того что требуется, просто посмотреть или
// нужно для дальнейших расчетов

int CheckElemBycountex(int[,] array, int row, int column)
{
    if(row > array.GetLength(0) || column > array.GetLength(1)) 
        return -1;
    else return array[row, column];
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
Console.Write("Input the row number of the element: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the column number of the element: ");
int column = Convert.ToInt32(Console.ReadLine());
int num = CheckElemBycountex(newArray, row, column);
Console.WriteLine(num);
*/

//=====================================================================

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number rows of your array: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number columns of your array: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



void ArithmMeanOfColumn(int[,] array)
{    
    double[] sumElem = new double[array.GetLength(1)];
    double n = array.GetLength(0);

    for (int j = 0; j < array.GetLength(1); j++)
        for (int i = 0; i < array.GetLength(0); i++)
            sumElem[j] = sumElem[j] + array[i, j]; 
               
    for (int count = 0; count < array.GetLength(1); count++)
        Console.Write(Math.Round(sumElem[count] / n,1) + " ");
    Console.WriteLine();    
}


int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
ArithmMeanOfColumn(newArray);


