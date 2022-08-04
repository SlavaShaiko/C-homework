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
//__________________________________________________________________________________________________________
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
*/
/*                     
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
//__________________________________________________________________________________________________
/*
Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/
/*
Console.Clear();
Console.WriteLine("Введи число:");
int a = Convert.ToInt32(Console.ReadLine());
int result = 1;
int index = 1;
while (index <= a)
{
    result = result * index;
    index++;
}
Console.WriteLine($"произведение чисел от 1 до {a} = {result}");
*/
/*
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
*/
/*
Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
/*
Console.Clear();

int[] array = new int[8];
int rndNum = new Random().Next(0, 2);
int count = array.Length;
for (int i = 0; i < count; i++)
{
    array[i] = new Random().Next(0, 2);
}
Console.Write("[");
for (int i = 0; i < count; i++)
{
    Console.Write(array[i]);
    if (i != array.Length - 1) Console.Write(",");
}
Console.Write("]");
*/
Console.Clear();
int[] array = GetRandomArray(8);
WriteArrayToConsole(array);

int[] GetRandomArray(int arrayLength)
{
    Random rnd = new Random();
    int[] arr = new int[arrayLength];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

void WriteArrayToConsole(int[] array)
{
    Console.Clear();
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(",");
    }
    Console.WriteLine("]");
}




