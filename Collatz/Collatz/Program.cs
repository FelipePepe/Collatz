Func<long, bool> isEven = (n) => n % 2 == 0;

Action<long> collatz = null;

collatz = (n) =>
{
    Console.WriteLine(n);
    if (n != 1)
    {
        collatz(isEven(n) ? (n / 2) : (n * 3) + 1);
    }
};

collatz(130);