// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем


Console.WriteLine("Первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Второе число: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Количество чисел: ");
int N = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Вывод последовательности: ");

Console.Write($"{a} {b} ");

for (int i = 0; i < N-2; i++)
{
    int result = a + b;
    a = b;
    b = result;
    Console.Write($"{result} ");
}




