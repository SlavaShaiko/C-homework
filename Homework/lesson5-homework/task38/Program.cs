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

// int[] ArrayRealNumber(int[] array)
// {
//     int maxReal = array.Max();
//     int minReal = array.Min();
//     int differenceOfElements = maxReal - minReal;
//     return new int[] { differenceOfElements };
// }

int[] ArrayRealNumber(int[] array)
{
    int minReal = array[0];
    int maxReal = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minReal) minReal = array[i];
        else
        {
            if (array[i] > maxReal) maxReal = array[i];
        }
    }
    return new int[] { maxReal - minReal };
}

int[] greateArrayRndDig = GreateArrayRndDig(6, 1, 12);
PrintArray(greateArrayRndDig);
int[] arrayRealNumber = ArrayRealNumber(greateArrayRndDig);
Console.WriteLine($" -> {arrayRealNumber[0]}");