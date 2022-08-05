/*Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int MetodResul(int result)
{
    int resulA = result / 10;
    int resulB = resulA % 10;
    return resulB;
}
int metodResul = MetodResul(numA);
Console.WriteLine($"{numA} -> {metodResul}");
*/

//------------------------------------------------------------------------------------------------

/*Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
Console.Clear();
Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int thirdDigit = numA;
if (numA < 99)
{
    Console.WriteLine($"{numA} -> третьей цифры нет");
}
else
{
    while (thirdDigit > 1000)
    {
        thirdDigit = thirdDigit / 10;
    }
    int resulA = thirdDigit % 10;
    Console.WriteLine($"{numA} -> {resulA}");
}
*/
/*
Console.WriteLine("Задача 13 ");
Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());

string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
*/

//------------------------------------------------------------------------------------------------

/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
/*
Console.Clear();
Console.Write("Введите цифру: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());
int i = dayWeek;
if (i == 0 || i > 7) Console.Write($"цифра {dayWeek} не стоответствует дню недели ");
else
{
    if (i == 6 || i == 7) Console.Write($"{dayWeek} -> да ");
    else
    {
        Console.Write($"{dayWeek} -> нет ");
    }
}
*/