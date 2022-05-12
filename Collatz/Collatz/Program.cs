Func<long, bool> isEven = (n) => n % 2 == 0;

Action<long> collatz = null;

collatz = (n) =>
{
    Console.WriteLine(n);

    long result = 0;

    if (isEven(n))
    {
        result = n / 2;
    }
    else
    {
        result = (n * 3) + 1;
    }

    if (result != 1)
    {
        collatz(result);
    }
    else
    {
        Console.WriteLine(result);
        return;
    }
};

collatz(130);