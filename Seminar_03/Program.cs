// ЗАДАЧА 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212->нет
// 12821->да
// 23432->да

// int PalindNumber (int num)
// {
//     int newNum = 0;
        
//     while(num>0)
//     {    
//         newNum = newNum * 10 + num % 10;
//         num = num / 10;  
//     }
//      return newNum;
// }
// bool Palindrom(int num)
// {    
//     int newNum = PalindNumber(num);
//     Console.WriteLine(newNum); 
    
//     return num == newNum;   
// }

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Palindrom(num));


//---------------------------------------------------------


// ЗАДАЧА 2. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double Distance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double a = Math.Pow((xB - xA),2); 
    double b = Math.Pow((yB - yA),2);
    double c = Math.Pow((zB - zA),2);
    return Math.Sqrt(a+b+c);
}

Console.Write("Input a first coordinate a first podouble: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a second coordinate a first podouble: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a third coordinate a first podouble: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a first coordinate a second podouble: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a second coordinate a second podouble: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a third coordinate a second podouble: ");
double zB = Convert.ToDouble(Console.ReadLine());

double dist = Math.Round(Distance(xA, yA, zA, xB, yB, zB),2);

Console.WriteLine($"Distace for podouble A to podouble B is {dist}");
*/
//-----------------------------------------------------------

// ЗАДАЧА 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
void CubeNumber(double maxNum)
{
    for(double num = 1; num <= maxNum; num++)
    Console.Write(Math.Pow(num,3)+" ");
    Console.WriteLine();
}

Console.Write("Input a number: ");
double num = Convert.ToDouble(Console.ReadLine());

CubeNumber(num);
*/
