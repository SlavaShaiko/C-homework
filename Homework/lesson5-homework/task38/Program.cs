// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным
//   и минимальным элементов массива.
// [3 7 22 2 78] -> 76
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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

int[] ArrayRealNumber(int[] array)
{
    int i = 0;
    int maxReal = 0;
    int minReal = 0;
    int count = array[i];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] < count) maxReal = array[j];
        else minReal = array[j];
    }
    return new int[] { maxReal - minReal };
}



int[] greateArrayRndDig = GreateArrayRndDig(6, -9, 9);
PrintArray(greateArrayRndDig);

// Console.WriteLine($"сумма отрицательных чисел равна {sumPosNegDig[0]}");
// Console.WriteLine($"сумма положительных чисел равна {sumPosNegDig[1],3}");
