/*Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
Console.Write("введите пятизначное число: ");
int palindrome = Convert.ToInt32(Console.ReadLine());
void Palindromecheck(int check)
{
    int leftPartPalindrome = check / 10000;
    int rightPartPalindrome = check % 10;
    int leftTenthPartPalindrome = check / 1000 % 10;
    int rightTenthPartPalindrome = check % 100 / 10;
    if (leftPartPalindrome == rightPartPalindrome || leftTenthPartPalindrome == rightTenthPartPalindrome)
    {
        Console.WriteLine($"{palindrome} -> да");
    }
    else
    {
        Console.WriteLine($"{palindrome} -> нет");
    }
}
Palindromecheck(palindrome);
