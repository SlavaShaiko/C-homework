// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Console.Clear();
// int[] ArrayRnd(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }
// void PrintArray(int[] array)

// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == 0) Console.Write("[");
//         if (i < array.Length - 1) Console.Write(array[i] + ", ");
//         else Console.Write(array[i] + "]");
//     }
// }

// void ReversArray(int[] array)
// {
//     int size = array.Length;
//     int index1 = 0;
//     int index2 = size - 1;
//     while (index1 < index2)
//     {
//         int obj = array[index1];
//         array[index1] = array[index2];
//         array[index2] = obj;
//         index1++;
//         index2--;
//     }
// }
// int[] arrayRnd = ArrayRnd(9, 1, 10);
// PrintArray(arrayRnd);
// Console.WriteLine();
// ReversArray(arrayRnd);
// PrintArray(arrayRnd);

//--------------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
// int first = GetUserInput();
// int second = GetUserInput();
// int third = GetUserInput();

// int GetUserInput()
// {
//     Console.Write("Введите число: ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// if (IsRectangle(first, second, third))
//     Console.WriteLine($"Треугольник со сторонами {first}, {second}, {third} может существовать.");
// else
//     Console.WriteLine($"Треугольник со сторонами {first}, {second}, {third} НЕ может существовать.");

// bool IsRectangle(int first, int second, int third)
// {
//     if (first < second + third && second < first + second && third < first + second)
//         return true;

//     return false;
// }

//------------------------------------------------------------------
// Console.Clear();

// Console.WriteLine("Введите число1: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число2: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число3: ");
// int numC = Convert.ToInt32(Console.ReadLine());


// bool Triangle(int num1, int num2, int num3)
// {
//     return num1 < (num2 + num3) && num2 < (num1 + num3) && num3 < (num2 + num1);
// }

// bool result = Triangle(numA, numB, numC);
// Console.WriteLine(result? "Является тругольником" : "Не может быть треугольником");

//--------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// void ToBin(int n)
// {
//     if (n == 0) return;
//     ToBin(n / 2);
//     Console.Write(n % 2);
// }
// ToBin(44);

//--------------------------------------------------------------------------------------------------------------------------------------------

// Console.Clear();
// int num = GetUserInput();
// System.Console.WriteLine(ConvertToBinary(num));
// string ConvertToBinary(int num)
// {
//     string binary = string.Empty;
//     while (num >= 1)
//     {
//         binary += num % 2;
//         num /= 2;
//     }
//     var item = binary.Reverse();
//     binary = "";
//     foreach (var i in item)
//     {
//         binary += i.ToString();
//     }
//     return binary;
// }
// int GetUserInput()
// {
//     Console.Write("Введите число: ");
//     return Convert.ToInt32(Console.ReadLine());
// }

//---------------------------------------------------

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string Result(int num1)
// {
//     string res = "";
//     while (num1 > 0)
//     {
//         res += num1 % 2;
//         num1 /= 2;
//     }
//     return res;
// }
// void PrintString(string result)
// {
//     for (int i = result.Length - 1; i >= 0; i--)
//     {
//         Console.Write(result[i]);
//     }
// }
// string res = Result(num);
// PrintString(res);

//------------------------------------------------------------------------------------------------------------------------------------------

// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int num = GetUserInput();
// WriteFibonachi(num);
// int GetUserInput()
// {
//     Console.Write("Введите число: ");
//     return Convert.ToInt32(Console.ReadLine());
// }
// void WriteFibonachi(int num)
// {
//     int first = 0;
//     int second = 1;
//     int tmp = 0;
//     Console.Write(first + " ");
//     Console.Write(second + " ");
//     for (int i = 0; i < num - 2; i++)
//     {
//         tmp = first;
//         first = second;
//         second += tmp;
//         Console.Write(second + " ");
//     }
//     Console.WriteLine();
// }

//--------------------------------------------------------------------------------------------------------------------------------------

// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

// Console.Clear();
// int[] ArrayRnd(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }
// void PrintArray(int[] array)

// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == 0) Console.Write("[");
//         if (i < array.Length - 1) Console.Write(array[i] + ", ");
//         else Console.Write(array[i] + "]");
//     }
// }

// int[] CopyArray(int[] array)
// {
//     int[] copyArr = new int[array.Length];

//     for (int i = 0; i < copyArr.Length; i++)
//     {
//         copyArr[i] = array[i];
//     }
//     copyArr[0] = 1;// проверка массива
//     return copyArr;
// }

// int[] arrayRnd = ArrayRnd(9, 1, 8);
// int[] copyArray = CopyArray(arrayRnd);
// Console.Write("Основной массив                               -> ");
// PrintArray(arrayRnd);
// Console.WriteLine();
// Console.Write("Скопированый массив с измененным [0] индексом -> ");
// CopyArray(arrayRnd);
// PrintArray(copyArray);
// Console.WriteLine();