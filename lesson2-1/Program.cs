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