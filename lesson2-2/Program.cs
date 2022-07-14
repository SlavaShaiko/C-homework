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
    int resulA = numA % 10;
    return resulA;
}
int metodResul = MetodResul(numA);
if (numA < 99)
{
    Console.WriteLine($"{numA} -> третьей цифры нет");
}
else
{
    Console.WriteLine($"{numA} -> {metodResul}");
}





