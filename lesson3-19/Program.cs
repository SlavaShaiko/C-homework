/*Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
Console.Clear();
Console.Write("введите пятизначное число: ");
int palindrome = Convert.ToInt32(Console.ReadLine());
int check = palindrome;
int variable = 0;
int currentVariable = 0;
while (check > 0)
{
    variable = check % 10;
    currentVariable = currentVariable * 10 + variable;
    check = check / 10;
}
if (palindrome == currentVariable)
{
    Console.WriteLine($"{palindrome} -> Да");
}
else
{
    Console.WriteLine($"{palindrome} -> Нет");
}
*/

Console.Clear();
Console.Write("введите пятизначное число: ");
int palindrome = Convert.ToInt32(Console.ReadLine());// Решение с помощью метода

void Palindromecheck(int check)
{
    int variable = 0;                // Решение с помощью метода
    int currentVariable = 0;
    while (check > 0)
    {
        variable = check % 10;
        currentVariable = currentVariable * 10 + variable;
        check = check / 10;
    }
    if (palindrome == currentVariable)
        Console.WriteLine($"{palindrome} -> Да");
    else
        Console.WriteLine($"{palindrome} -> Нет");

}
Palindromecheck(palindrome);