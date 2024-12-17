namespace Eulerovka;

public static class Eulerada
{
    public static List<long> EulerovaPrvocisla(long number)
    {
        var factors = new List<long>();
        
        for (long i = 2; i * i <= number; i++)
        {
            while (number % i == 0)
            {
                factors.Add(i);
                number /= i;
            }
        }
        
        if (number > 1)
        {
            factors.Add(number);
        }

        return factors;
    }
}