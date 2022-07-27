/*17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.
Console.Clear();
Console.WriteLine("Введите координат точек ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("первая четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("вторая четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("третья четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("четвертая четверть");
}
else
{
    Console.WriteLine("неверные координаты");
}
*/

/*
17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.
Console.Clear();
Console.WriteLine("Введите координат точек ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());
string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return ("первая четверть");
    if (xc < 0 && yc > 0) return ("вторая четверть");
    if (xc < 0 && yc < 0) return ("третья четверть");
    if (xc > 0 && yc < 0) return ("четвертая четверть");
    return ("неверные координаты");

}
string quarter = Quarter(x, y);
Console.WriteLine($"{quarter} {x} : {y}");
*/

/*
Задача 18. Напишити программу, 
которая по задонному номеручетверти, 
показывает диапазон возможных координат точек в этой четверти от x до y
Console.Clear();
Console.WriteLine("Введите номер четверти ");
int x = Convert.ToInt32(Console.ReadLine());
string Quarter(int xc)
{
    if (xc == 1) return ("xc > 0 и yc > 0");
    if (xc == 2) return ("xc < 0 и yc > 0");
    if (xc == 3) return ("xc < 0 и yc < 0");
    if (xc == 4) return ("xc > 0 и yc < 0");
    return ("неверные координаты");
}
string quarter = Quarter(x);
Console.WriteLine($"{quarter}");
*/

/*
Задача 20: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
Console.Clear();
Console.Write("введите x координаты:");
int firstX = Convert.ToInt32(Console.ReadLine());
Console.Write("введите y координаты:");
int firstY = Convert.ToInt32(Console.ReadLine());
Console.Write("введите y координаты:");
int secondX = Convert.ToInt32(Console.ReadLine());
Console.Write("введите y координаты:");
int secondY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetDistance(firstX, firstY, secondX, secondY));
double GetDistance(int ax, int ay, int bx, int by)
{
    return Math.Round(Math.Sqrt(((bx - ax) * (bx - ax)) + ((by - ay) * (by - ay))), 2, MidpointRounding.ToZero);
}
*/

/*
Задача 22: Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
WriteSquareTable(n);
void WriteSquareTable(int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.WriteLine($" | {i} | {i * i, 2} | ");
        i++;
    }
}
*/


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
/*
Console.Clear();
Console.Write("введите пятизначное число: ");
int palindrome = Convert.ToInt32(Console.ReadLine());

void Palindromecheck(int check)
{
    int variable = 0;
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
*/

//Виды методов(функций)

//Метод1
/*void Metod()                             //ничего не возвращает и ничего не принемает!!!
{
    Console.WriteLine("любой текст");
}
//Metod();            //вызов метода
*/

//Метод2
/*
void Metod(string msg, int count)          //ничего не возвращает но принемает!!!
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Metod(msg: "любой текст", count: 4); //можно указывать и следующим методом
Metod("любой текст", 4);            //вызов метода
*/
/*
//Метод3 
int Metod()                               //что-то возврашает но ничего не принемают!!!
{
    return DateTime.Now.Year;
}
int year=Metod();
Console.WriteLine(year);
*/

//Метод4 
/*
Console.Clear();
string Metod(int count, string text)            //что-то принемает и что-то возвращает!!! 
{
    int i = 0;
    string result = String.Empty;               //String.Empty означает пустую строку
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;    // возврта результата
}
string metod = Metod(5, "любой текст ");
Console.WriteLine(metod);
Console.WriteLine("");
*/

//For
/*
Console.Clear();
string Metod(int count, string text)            //что-то принемает и что-то возвращает!!! 
{
    string result = String.Empty;               //String.Empty означает пустую строку
    for (int i = 0; i < count; i++) //for (1 инициализация счётчика, 2 условия счётчика,3 увеличение счетчика)
    {
        result = result + text;
    }
    return result;    // возврта результата
}
string metod = Metod(5, "любой текст ");
Console.WriteLine(metod);
Console.WriteLine("");
*/

//for->for
/*
Console.Clear();                  //таблица умножения
for (int i = 2; i <= 10; i++) //for (1 инициализация счётчика, 2 условия счётчика,3 увеличение счетчика)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}x{j}={i * j}"); //интерполяция строк
    }
    Console.WriteLine();
}
*/

/*Дан текст. В тексте нужно все пробелы заменить черточками, 
маленькие буквы “к” заменить большими “К”, а большие “С” заменить 
маленькими “с”.
Ясна ли задача?*/
/*
Console.Clear();
string text = "Дан текст. В тексте нужно все пробелы заменить черточками,"
            + "маленькие буквы “к” заменить большими “К”, а большие “С” заменить"
            + "маленькими “с”."
            + "Ясна ли задача?*;
//string text = "Дан текст. В тексте нужно все пробелы заменить черточками,";
//               0123456789
//text[2] //н
string Replace(string text, char oldValue, char newValue)//метод
{
    string result = String.Empty;    //определяем пустую строку

    int length = text.Length;   //определяем и присваиваем длину строки
    for (int i = 0; i < length; i++)

    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
*/


//Ctrl +K+C для закомментирования кода
//Ctrl +K+U и для раcкомментирования кода

/*
1.Найти позицию минимального элемента
в неотсортированной части массива
2. Произвести обмен этого значения со 
значением первой неотсортированной позиции
3. Повторять пока есть не отсортированные 
элементы
int[] arr = { 9, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
                minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/

// 1.Найти позицию максимального элемента
// в неотсортированной части массива
// 2. Произвести обмен этого значения со 
// значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные 
// элементы
Console.Clear();
int[] arr = { 1, 4, 7, 9, 2, 4, 5, 6, 4, 1, 1, 2, 3 };
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i],3}");
    }
    Console.WriteLine();
}

void SelectionSort1(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
                minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
                maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort1(arr);
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);


































// using System;

// public class MainClass
// {
//     public static void Main()
//     {
//         Console.WriteLine("Введите два числа через пробел: длина и ширина стола");
//         string line = Console.ReadLine();
//         string[] splitString = line.Split(' ');

//         double length = Convert.ToDouble(splitString[0]); // длина
//         double width = Convert.ToDouble(splitString[1]); // ширина

//         //Тут будет Ваш код

//         Console.WriteLine($"Площадь стола: {(length-0.2) * (width-0.2)}"); 
//     }
// }






