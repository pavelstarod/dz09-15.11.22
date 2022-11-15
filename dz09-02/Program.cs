// Найти сумму элементов от M до N, N и M заданы



int Sum(int M, int N)
{
    int count = 0;
    for (int i = 0; i <= N - M; i++)
    {
        count = count + (M + i);
    }
    return count;
}

int M = 3;
int N = 11;

int summa = Sum(M, N);
Console.WriteLine($"Cуммa элементов от M до N: {summa}");



