/*
Задача 2: Напишите программу, которая на вход 
принимает два числа и выдаёт, какое число большее, а 
какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Clear();
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



