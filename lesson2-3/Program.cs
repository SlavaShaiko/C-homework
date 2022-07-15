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
