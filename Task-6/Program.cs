/*
Задача 6: Напишите программу, которая на вход 
принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

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