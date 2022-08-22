// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2->A(m, n) = 29

//             n+1              если m=0 
//   A(m,n)=   A(m-1,1)         если m!=0 and n=0
//             A(m-1,A(m,n-1))  если m>0  and n>0
Console.Clear();
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintResult(m, n);
void PrintResult(int m, int n)
{
    if (m >= 0 && n >= 0)
    {
        int sum = AckermanFunctions(m, n);
        Console.Write($"Результат значение функции Аккермана для двух неотрицательных целых чисел: m = {m}, n= {n} -> A(m,n) = {sum}  ");
        Console.WriteLine();
    }
    else
    {
        Console.Write($"Введено отрицательное число!: m = {m}, n = {n}");
        Console.WriteLine();
    }
}
int AckermanFunctions(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
       if (m != 0 && n == 0)
        return AckermanFunctions(m - 1, 1);
    else
        return AckermanFunctions(m - 1, AckermanFunctions(m, n - 1));
}