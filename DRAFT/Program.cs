// using System;

// namespace MyConsole
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int chilso = 7879;        // число в десятичной
//             Console.WriteLine("Число в 10-й системе = " + chilso);
//             int osnov = 16;  // основание числа
//             string result = "";     // переменная для результата
//             int temp = 0;

//             if (chilso > 0)     // условие, что число больше 0
//                 while (chilso >= (osnov - 1))   // цикл, пока число больше самого основания
//                 {
//                     temp = chilso % osnov;      
//                     chilso = (chilso - temp) / osnov;
//                     result = Convert.ToString(temp) + result;
//                 }

//             result = Convert.ToString(chilso) + result;
//             Console.WriteLine("Число в " + osnov + "-й системе = " + result);

//         }
//     }
// }

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication52
{
    class Program
    {
        static string[] chislo(int n)
        {
            int i;
            int b;
            int q;
            string[] s = new string[20];
            for (i = 0; n > 0; i++)
            {
                b = n;
                n = n / 16;
                q = b - n * 16;

                if (q > 9)
                {
                    if (q == 10)
                    {
                        s[i] = "a";
                        continue;
                    }
                    if (q == 11)
                    {
                        s[i] = "b";
                        continue;
                    }
                    if (q == 12)
                    {
                        s[i] = "c";
                        continue;
                    }
                    if (q == 13)
                    {
                        s[i] = "d";
                        continue;
                    }
                    if (q == 14)
                    {
                        s[i] = "e";
                        continue;
                    }
                    if (q == 15)
                        s[i] = "f";
                }
                else
                {
                    s[i] = Convert.ToString(q);
                }
            }
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
            return s;
        }
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            chislo(a);
        }
    }
}*/
using System;

public class MainClass
{
    public static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());

        int minValue = 0;    
        int maxValue = a;   

        if ((a <= b) && (a <= c) && (a <= d)) minValue = a;
        if ((b <= a) && (b <= c) && (b <= d)) minValue = b;
        if ((c <= a) && (c <= b) && (c <= d)) minValue = c;
        if ((d <= a) && (d <= b) && (d <= c)) minValue = d;

        if ((a >= b) && (a >= c) && (a >= d)) maxValue = a;
        if ((b >= a) && (b >= c) && (b >= d)) maxValue = b;
        if ((c >= a) && (c >= b) && (c >= d)) maxValue = c;
        if ((d >= a) && (d >= b) && (d >= c)) maxValue = d;

         

        
        Console.WriteLine($"{minValue}  {maxValue}");

    }
}