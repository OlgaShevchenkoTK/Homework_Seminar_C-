// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
/*
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
    Console.WriteLine();

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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

void SortArrayRowValueMaxToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxPosition = j;
            for (int i1 = j + 1; i1 < array.GetLength(1); i1++)
                if (array[i, i1] > array[i, maxPosition])
                    maxPosition = i1;
            int temp = array[i, j];
            array[i, j] = array[i, maxPosition];
            array[i, maxPosition] = temp;
        }
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
SortArrayRowValueMaxToMin(newArray);
Show2dArray(newArray);
*/

//========================================================================

// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
/*
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
    Console.WriteLine();

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
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

void MinSumValuesRow(int[,] array)
{
    int[] sumElemRow = new int[array.GetLength(0)];
    int minPositionRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sumElemRow[i] = sumElemRow[i] + array[i, j];
    for (int i1 = 0; i1 < array.GetLength(0); i1++)
    {
        if (sumElemRow[i1] < sumElemRow[minPositionRow])
            minPositionRow = i1;
        Console.WriteLine($"The sum of the values of row {i1 + 1} is equal to {sumElemRow[i1]}");
    }
    Console.WriteLine();
    Console.WriteLine($"Miniimum sum of values in a row is number: {minPositionRow + 1}");
    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
MinSumValuesRow(newArray);
*/
//========================================================================

// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number rows of your matrix: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number columns of your matrix: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultiplicationMatr1Matr2(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixRes = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    if (matrix1.GetLength(1) == matrix2.GetLength(0))
        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix2.GetLength(1); j++)
                for (int k = 0; k < matrix1.GetLength(1); k++)
                    matrixRes[i, j] += matrix1[i, k] * matrix2[k, j];
    else Console.WriteLine("ERROR! Умножение невозможно!");

    Show2dArray(matrixRes);
}

int[,] matrix1 = CreateRandom2dArray();
int[,] matrix2 = CreateRandom2dArray();
Show2dArray(matrix1);
Show2dArray(matrix2);
MultiplicationMatr1Matr2(matrix1, matrix2);

*/
//=======================================================================

// Задача 4. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*
// Задали трехмерный массив из случайных целых двузначных чисел
int[,,] CreateRandom3dArray()
{
    Console.Write("Input a number rows for your array: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a numbers columns for your array: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a numbers lists for your array: ");
    int lists = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,,] array = new int[rows, columns, lists];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                array[i, j, k] = new Random().Next(10, 100);
    return array;
}

// Метод вывода трехмерного массива построчно
void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})");
                Console.WriteLine();
            }
        Console.WriteLine();
    }
}

// Метод замены в массиве повторяющихся значений
//(КОММЕНТАРИЙ: Метод, конечно получился громоздкий и сохраняет вероятность повторений,
//но вполне рабочий. Возможно с большими знаниями и практикой смогу сделать что-то более компактное)

void ReplacingDuplications3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                for (int i1 = 0; i1 < array.GetLength(0); i1++)
                    for (int ind = 0; ind < array.GetLength(1); ind++)
                        for (int index = 0; index < array.GetLength(2); index++)
                            if (array[i, j, k] == array[i1, ind, index])
                            {
                                int temp = array[i, j, k];
                                array[i1, ind, index] = new Random().Next(10, 100);
                                array[i, j, k] = temp;
                            }
}

int[,,] newArray = CreateRandom3dArray();
Show3dArray(newArray);
ReplacingDuplications3dArray(newArray);
Show3dArray(newArray);
*/
//======================================================================

// Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


