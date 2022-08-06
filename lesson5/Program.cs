// Андрей Булгаков: Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.
/*
Console.Clear();
int[] GreateArrayRndDig(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
int[] SumPosNegDig(int[] arr)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
            sumNeg += arr[i];
        else
            sumPos += arr[i];
    }
    return new int[] { sumNeg, sumPos };
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}
int[] greateArrayRndDig = GreateArrayRndDig(12, -9, 9);
int[] sumPosNegDig = SumPosNegDig(greateArrayRndDig);
PrintArray(greateArrayRndDig);
Console.WriteLine();
Console.WriteLine($"сумма отрицательных чисел равна {sumPosNegDig[0]}");
Console.WriteLine($"сумма положительных чисел равна {sumPosNegDig[1],3}");
*/
//---------------------------------------------------------------------------------------------------------
// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
Console.Clear();
int[] GreateArrayRndDig(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void ArrayDig(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i] + "]");
    }
}
int[] greateArrayRndDig = GreateArrayRndDig(4, -9, 9);
PrintArray(greateArrayRndDig);
ArrayDig(greateArrayRndDig);
Console.Write(" -> ");
PrintArray(greateArrayRndDig);



























// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
