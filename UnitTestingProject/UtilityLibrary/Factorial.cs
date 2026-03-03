using System;

namespace TestApp;

public class Factorial
{
    public static int CalculateFactorial(int n)
    {
        if (n < 0)
            throw new
     ArgumentOutOfRangeException(nameof(n), "Number cannot be negative");

        if (n == 0)
            return 1;

        return n * CalculateFactorial(n - 1);
    }
}
