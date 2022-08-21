// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2->A(m, n) = 29



//             n+1              if m=0 
//   A(m,n)=   A(m-1,1)         if m>0 and n=0
//             A(m-1,A(m,n-1))  if m>0 and n>0


Console.Clear();
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;

int sum = AckermanFunction(m, n, result);
Console.Write($"Результат функции Аккермана: m = {m}, n= {n} -> A(m,n) = {sum} ");

int AckermanFunctions(int m, int n, int res)
{
    if (m > n) return res;
    else
    {
        res = res + m;
        return AckermanFunction(m + 1, n, res);
    }
}


