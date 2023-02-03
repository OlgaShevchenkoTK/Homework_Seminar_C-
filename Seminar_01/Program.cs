// ЗАДАЧА 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5 b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
/*
int a1 = 5, b1 = 7,
    a2 = 2, b2 = 10,
    a3 = -9, b3 = -3;

int max1 = a1,
    max2 = a2,
    max3 = a3;

if (b1 > max1)
{
   max1 = b1; 
}

if (b2 > max2)
{
    max2 = b2;
}

if (b3 > max3)
{
    max3 = b3;
}

Console.WriteLine(max1);
Console.WriteLine(max2);
Console.WriteLine(max3);

*/

// ЗАДАЧА 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
/*
int a1 = 2, b1 = 3, c1 = 7,
    a2 =44, b2 = 5, c2 = 78,
    a3 = 22, b3 = 3, c3 = 9;

int max1 = a1,
    max2 = a2,
    max3 = a3;

if (b1 > max1)
{
   max1 = b1;
}
if(c1 > max1)
   {
    max1 = c1;
   } 

if (b2 > max2)
{
    max2 = b2;
}
if(c2 > max2)
    {
        max2 = c2;
    }

if (b3 > max3)
{
    max3 = b3;
}
if(c3 > max3)
    {
        max3 = c3;
    }

Console.WriteLine(max1);
Console.WriteLine(max2);
Console.WriteLine(max3);

*/

// ЗАДАЧА 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
/*
int a1 = 4, a2 = -3, a3 = 7;

int num1 = a1 % 2, num2 = a2 % 2, num3 = a3 % 2;

if(num1 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

if(num2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

if(num3 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

*/

// ЗАДАЧА 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
/*
int N = 1;

int result = 0;

for (N=1; N <= 5; N++) 
{
    result = N%2;
    if (result == 0)
    {
        Console.Write(N);
        Console.Write(", ");                     
    }
}

Console.WriteLine();  

for (N=1; N <= 8; N++)
{
        result = N%2;
    if (result == 0)
    {
        Console.Write(N);
        Console.Write(", ");        
    }
}

Console.WriteLine(); 
*/
