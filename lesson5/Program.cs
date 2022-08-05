
int[] GetSumPosNegElem(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNeg += array[i];
        }
        else
        {
            sumPos += array[i];
        }
    }
    return new int[] {sumNeg, sumPos};
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}
int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int[] sumPosNegElem = GetSumPosNegElem(array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {sumPosNegElem[1]}");
Console.WriteLine($"Сумма отрицательных чисел = {sumPosNegElem[0]}");


// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
