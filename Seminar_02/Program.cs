// ЗАДАЧА 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
int CharacterSecond(int number)
{
    int newNumber = number/10%10;
    return newNumber;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int newNumber = CharacterSecond(number);
Console.WriteLine($"Вторая цифра числа {number} - {newNumber}.");
*/

// ЗАДАЧА 2. Напишите программу, которая выводит третью цифру заданного числа.
// 645 -> 5
// 32679 -> 6
// 21 -> -1

/*
int CountDigits (int number)
{
    int n = 0; // n - количество разрядов в заданном числе
    while(number > 0)
    {
        number /=10;
        n++;
    } 
    return n;
}
int CharacterTherd(int number)
{
    int n = CountDigits(number);
    if (n <= 2) 
    {
        int newNumber = -1;
        return newNumber;
    }
        else
    {
        int newNumber = number % Convert.ToInt32(Math.Pow(10,n-2));
        newNumber = newNumber / Convert.ToInt32(Math.Pow(10,n-3)); 
        return newNumber;  
    }        
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int newNumber = CharacterTherd(number);
Console.WriteLine($"Третья цифра числа: {number} - {newNumber}");
*/

// ЗАДАЧА 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//           и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
/*
bool Weekend (int number)
{
    if (number <= 5)
    {
        return false;
    }
    else
    {
        return true;
    }
    
}

Console.Write("Input a number from 1 to 7: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Weekend(number);
Console.WriteLine(result);
*/
