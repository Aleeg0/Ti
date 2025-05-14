using System.Numerics;
using System.Text;

namespace Lab4;

public static class Algorithms
{

    public static BigInteger GetHashByText(List<string> text, BigInteger n)
    {
        BigInteger hash = 100;
        foreach (var line in text)
        {
            foreach (var symbol in Encoding.ASCII.GetBytes(line))
            {
                hash = (hash + symbol) % n;           
            }
        }
        
        return hash;
    }
    
    public static BigInteger GetHashBySign(BigInteger sign, BigInteger e, BigInteger r)
    {
        return ModPow(sign, e, r);
    }

    public static BigInteger Sign(BigInteger m, BigInteger d, BigInteger r)
    {
        return ModPow(m, d, r);
    }

    public static (BigInteger x1, BigInteger y1, BigInteger d1) EuclidExt(BigInteger a, BigInteger b)
    {
        BigInteger d0 = a, d1 = b,
            x0 = 1, x1 = 0,
            y0 = 0, y1 = 1;
        while (d1 > 1)
        {
            BigInteger q = d0 / d1;
            BigInteger d2 = d0 % d1;
            BigInteger x2 = x0 - q * x1;
            BigInteger y2 = y0 - q * y1;
            d0 = d1; d1 = d2;
            x0 = x1; x1 = x2;
            y0 = y1; y1 = y2;
        }

        return (x1, y1, d1);
    }
    
    public static bool IsPrimeMillerRabin(BigInteger number, int iterations = 40)
    {
        if (number <= 1) return false;
        if (number == 2 || number == 3) return true;
        if (number % 2 == 0) return false;

        // Записываем n-1 в виде d*2^s
        BigInteger d = number - 1;
        int s = 0;

        while (d % 2 == 0)
        {
            d /= 2;
            s++;
        }

        for (int i = 0; i < iterations; i++)
        {
            BigInteger x = BigInteger.ModPow(2, d, number);
        
            if (x == 1 || x == number - 1)
                continue;
        
            for (int j = 0; j < s - 1; j++)
            {
                x = BigInteger.ModPow(x, 2, number);
                if (x == 1) return false;
                if (x == number - 1) break;
            }
        
            if (x != number - 1) return false;
        }
    
        return true;
    }
    
    private static BigInteger ModPow(BigInteger a, BigInteger z, BigInteger n)
    {
        BigInteger result = BigInteger.One;
        
        while (z != 0)
        {
            while (z % 2 == BigInteger.Zero)
            {
                z /= 2;
                a = (a * a) % n;
            }

            z -= BigInteger.One;
            result = (result * a) % n;
        }
        
        return result;
    }
}