// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Clear();
// Console.Write("Введите число N:");
// int number = Convert.ToInt32(Console.ReadLine());

// void NaturalNumber(int num)
// {
//     if (num == 0) return;
//     NaturalNumber(num - 1);
//     Console.Write($"{num}  ");
// }

// NaturalNumber(number);

//---------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Clear();
Console.Write("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int numM, int numN)
{
    if (numM == numN)
        Console.Write($"{numM} ");
    else if (numM < numN)
        WriteNatural(numM, numN);
    else
        WriteNaturalJ(numN, numM);
}
NaturalNumber(numberM, numberN);
Console.WriteLine();


void WriteNatural(int from, int to)
{
    if (from > to)
        return;
    Console.Write($"{from} ");
    NaturalNumber(++from, to);
}

void WriteNaturalJ(int from, int to)
{
    if (from > to)
        return;
    Console.Write($"{to} ");
    NaturalNumber(from, --to);
}



//----------------------------------------------------------------------------------------------------------------------------------------------------
