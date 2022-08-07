// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] ArraySumNegInd(int[] array)
{
    int countPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            countPos += array[i];
        }
    }
    return new int[] { countPos };
}

int[] greateArrayRndDig = GreateArrayRndDig(20, -10, 10);
PrintArray(greateArrayRndDig);
int[] arraySumNegInd = ArraySumNegInd(greateArrayRndDig);
Console.WriteLine($" -> {arraySumNegInd[0]}");
















