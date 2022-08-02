/*
Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
int sum = 0;
while (count <= a)
{
    sum = sum + count;
    count++;
}
Console.WriteLine($"Сумма чисел от 1 до {a} -> {sum}");










