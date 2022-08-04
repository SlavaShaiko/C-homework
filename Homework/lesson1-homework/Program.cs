/*
Задача 2: Напишите программу, которая на вход 
принимает два числа и выдаёт, какое число большее, а 
какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

System.Console.Clear();
Console.Write("Введите первое число= ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число= ");
int numB = Convert.ToInt32(Console.ReadLine());

int max = numA;
int min = numB;

if(numA > numB)
{
   max = numA;
   min = numB;
   Console.WriteLine($"Наибльшее число = {max}, наименьшее число = {min}");
}
    else
    {
        Console.WriteLine($"Наибльшее число = {min}, наименьшее число = {max}");
    }
*/
//----------------------------------------------------------------------------------------------------
/*Задача 4: Напишите программу, которая принимает на 
вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.Clear();
Console.Write("Введите первое число= ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число= ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число= ");
int numС = Convert.ToInt32(Console.ReadLine());

int max = numA;

if(numA > numB)
{ 
   max = numA; 
}
else
{
    max = numB;
}
if(numС > max)
 {
    max = numС;
 }
  Console.WriteLine($"Максимальное число из трёх= {max}  ");
*/
//---------------------------------------------------------------------------------------------------
/*
Задача 6: Напишите программу, которая на вход 
принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет

Console.Clear();
Console.Write("Введите число для проверки = ");
int numA = Convert.ToInt32(Console.ReadLine());
int result = numA % 2; 
if (result == 1)
{
    Console.WriteLine("ODD NUMBER");
}
    else
    {
    Console.WriteLine("AN EVEN NUMBER");
    }
*/
//-------------------------------------------------------------------------------------------------------
/*
Задача 8: Напишите программу, которая на вход 
принимает число (N), а на выходе показывает все чётные 
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Clear();
Console.Write("Введите число N= ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 2;

while(index <= N)
{
    Console.Write($"  {index}  ");
    index = index + 2;
}