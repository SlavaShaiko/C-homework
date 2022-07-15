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


