
Console.Clear();
Console.Write("Введите цифру: ");
int numA = Convert.ToInt32(Console.ReadLine());
static void Main(string[] numA)
{
    int n = 999454643;
    int d = GetSecondDigit(n);
    Console.WriteLine(d);
    Console.ReadKey();
}

static int GetSecondDigit(int k)
{
    while (k >= 100) k /= 100;
    int d = k % 10;
    return d;
}