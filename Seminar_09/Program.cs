// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNum(int N)
{
    Console.Write(N + " ");
    if(N > 1) ShowNum(N-1);    
}

Console.WriteLine("Input a number: ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNum(N);
Console.WriteLine();
*/
//=================================================
// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int SumElem(int M, int N)
{
    if (M < N) return M + SumElem(M + 1, N);
    if (M > N) return M + SumElem(M - 1, N);
    return M;

}

Console.Write("Input the first number:");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumElem(M, N));
*/

//=================================================
// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int CalculatingAckermanFunction(int m, int n) 
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return CalculatingAckermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return CalculatingAckermanFunction(m - 1, CalculatingAckermanFunction(m, n - 1));
    return -1;
}

Console.Write("Input the first number:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CalculatingAckermanFunction(m, n));
