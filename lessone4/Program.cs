/*
Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int SumOfNumbers(int number)
{
    int count = 1;
    int sum = 0;
    while (count <= number)
    {
        sum = sum + count;
        count++;
    }
    return sum;
}
int result = SumOfNumbers(num);
Console.WriteLine($"Сумма чисел от 1 до {num} -> {result}");
*/

/*
Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

int NumberOfDigits(int number)
{
    while (number > 0)
    {
        number = number / 10;
        count += 1;

    }
    return count;
}
int number = NumberOfDigits(num);

Console.WriteLine($"{num} -> {number}");

//______________________________________________________________

Console.Clear();
Console.WriteLine("Введи число:");
int a = Convert.ToInt32(Console.ReadLine());

int GetCountNum(int numb)
{
    int index = 1;
    int x = 0;
    while (index <= numb)
    {
        x = x + 1;
        index = index * 10;
    }
    return x;
}
int res = GetCountNum(a);
Console.WriteLine($"Количество цифр в числе = {res}");
*/

/*
Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
12 мин
*/

Console.Clear();
Console.WriteLine("Введи число:");
int a = Convert.ToInt32(Console.ReadLine());
int GetMulti(int numb)
{
    int res = 1;
    for (int i = 1; i <= numb; i++)
    {
        res = res * i;
    }
    return res;
}

int sum = GetMulti(a);
Console.WriteLine($"произведение чисел от 1 до {a} = {sum}");





