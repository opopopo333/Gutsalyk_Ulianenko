using System;

int result = Fibonacci(5);
Console.WriteLine(result);

/// <summary>
/// Вычисляет n-е число в последовательности Фибоначчи.
/// </summary>
/// <remarks>
/// Используется итеративный подход (цикл for), что более эффективно по памяти, 
/// чем рекурсия, так как сложность алгоритма составляет O(n).
/// </remarks>
/// <param name="n">Порядковый номер числа Фибоначчи (начиная с 0).</param>
/// <returns>Значение n-го числа Фибоначчи.</returns>
static int Fibonacci(int n)
{
    Console.WriteLine("The output is: ");

    if (n <= 0) return 0;
    if (n == 1) return 1;

    int n1 = 0; // Первое число (F0)
    int n2 = 1; // Второе число (F1)
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }

    // Возвращаем результат в зависимости от входного n
    return n == 0 ? n1 : n2;
}