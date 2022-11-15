// Написать программу вычисления функции Аккермана


int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Ackerman(m - 1, 1);
    if (m > 0 && n > 0)
        return Ackerman(m - 1, Ackerman(m, n - 1));
    return Ackerman(m, n);
}

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

int ackermanFunction = Ackerman(m, n);
Console.WriteLine($"Вывод: {ackermanFunction}");

