/*16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет

Console.Clear();
Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

int result = numA * numA;
if (result == numB)
{
    Console.WriteLine($"{numA}, {numB} -> да");
}
else
{
    if (numB * numB == numA)
    {
        Console.WriteLine($"{numA}, {numB} -> да");
    }
    else
    {
        Console.WriteLine($"{numA}, {numB} -> нет");
    }
}
*/

/*Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*Console.Clear();
Console.Write("Введите трёхзначное число: ");
int numA = Convert.ToInt32(Console.ReadLine());
int resulA = numA / 10;
int resulB = resulA % 10;
Console.WriteLine($"{numA} -> {resulB}");
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

/*Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*Console.Clear();
Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA < 99)
{
    Console.WriteLine($"{numA} -> третьей цифры нет");
}
else
{
    int resulA = numA % 10;
    Console.WriteLine($"{numA} -> {resulA}");
}
*/
/*
Console.Clear();
Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

int MetodResul(int result)
{
    if (result < 0 || result < 99)
    {
        Console.WriteLine($"{result} -> третьей цифры нет");
        return result;
    }
    else
    {
        if (result < 999)
        {
            int resulA = result % 10;
            Console.WriteLine($"{result} -> {resulA}");
        }
        else
        {
            if (result < 9999)
            {
                int resulA = result % 100 / 10;
                Console.WriteLine($"{result} -> {resulA}");
            }
            else
            {
                if (result < 99999)
                {
                    int resulA = result % 1000 / 100;
                    Console.WriteLine($"{result} -> {resulA}");
                }
            }
        }
    }
    return result;
}
int metodResul = MetodResul(numA);
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


/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
/*
Console.Clear();
Console.Write("Введите цифру: ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA == 1)
{
    Console.Write($"{numA} -> нет");
}
else
{
    if (numA == 2)
    {
        Console.Write($"{numA} -> нет");
    }
    else
    {
        if (numA == 3)
        {
            Console.Write($"{numA} -> нет");
        }
        else
        {
            if (numA == 4)
            {
                Console.Write($"{numA} -> нет");
            }
            else
            {
                if (numA == 5)
                {
                    Console.Write($"{numA} -> нет");
                }
                else
                {
                    if (numA == 6)
                    {
                        Console.Write($"{numA} -> да");
                    }
                    else
                    {
                        if (numA == 7)
                        {
                            Console.Write($"{numA} -> да");
                        }
                    }
                }
            }
        }
    }
}
*/

//if(week < 1 || week > 7) -> неверная цифра
//else if (week > 0 && week < 6) -> нет
//и т.д. Возвращать из метода можно ответ (да, нет, неверная цифра), а вне метода выводить результат в
/*
Console.Clear();
Console.Write("Введите цифру: ");
int numA = Convert.ToInt32(Console.ReadLine());

int MetodDay(int week)
{
    if (week < 1 || week > 7) 
    {
        Console.WriteLine($"{week} -> неверная цифра");
    }
    else if (week > 0 && week < 6) 
    {
        Console.WriteLine($"{week} -> нет");
    }
return week;
}
int metodResul = MetodDay(numA);

Console.WriteLine($"{metodResul} -> да");
*/

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("(этот день выходной) -> да");
    }
    else
    if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("это вообще не день недели");
    }
    else
    {
        Console.WriteLine("(этот день не выходной) -> нет");
    }
}

CheckingTheDayOfTheWeek(dayNumber);
