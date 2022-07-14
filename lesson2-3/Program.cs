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
Console.Clear();
Console.Write("Введите цифру: ");
int numA = Convert.ToInt32(Console.ReadLine());

int MetodDay(int week)
{
    int num = 0;
    if (week == 1)
    {
        num = 1;
        Console.WriteLine($"{numA} -> нет");
        return num;
    }
    else
    {
        if (week == 2)
        {
            num = 2;
            Console.WriteLine($"{numA} -> нет");
            return num;
        }
        else
        {
            if (week == 3)
            {
                num = 3;
                Console.WriteLine($"{numA} -> нет");
                return num;
            }
            else
            {
                if (week == 4)
                {
                    num = 4;
                    Console.WriteLine($"{numA} -> нет");
                    return num;
                }
                else
                {
                    if (week == 5)
                    {
                        num = 5;
                        Console.WriteLine($"{numA} -> нет");
                        return num;
                    }
                    else
                    {
                        if (week == 6)
                        {
                            num = 6;
                            Console.WriteLine($"{numA} -> да");
                            return num;
                        }
                        else
                        {
                            if (week == 7)
                            {
                                num = 7;
                                Console.WriteLine($"{numA} -> да");
                                return num;
                            }
                            else
                            {
                                if (week > 7)
                                {
                                    num = 8;
                                    Console.WriteLine($"{numA} неверная цифра");
                                    return num;
                                }
                                else
                                {
                                    if (week <= 0)
                                    {
                                        num = 9;
                                        Console.WriteLine($"{numA} неверная цифра");
                                        return num;
                                    }
                                }
                            }
                            Console.WriteLine($"{numA} да");
                            return week;
                        }
                    }
                }
            }
        }
    }
}


int metodResul = MetodDay(numA);