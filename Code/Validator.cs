using System.Numerics;

namespace Lab4;

public static class Validator
{
    public static (bool isGood, string error) ValidateArg(string str, string name)
    {
        if (!BigInteger.TryParse(str, out var value))
            return (false, $"{name} должно быть числом");

        if (value < 0)
            return (false, $"{name} должно быть больше 0");

        if (!Algorithms.IsPrimeMillerRabin(value))
            return (false, $"{name} должно быть простым");
        
        return (true, "");
    }


    public static (bool isGood, string error) ValidateD(string str, BigInteger fR)
    {
        if (!BigInteger.TryParse(str, out var value))
            return (false, $"D должно быть числом");

        if (value <= 1 || value >= fR)
            return (false, $"D должно быть больше 1 и меньше значения функции Эйлера {fR}");

        if (Algorithms.EuclidExt(fR, value).d1 != 1)
            return (false, "D должен быть взаимно простым с функций Эйлера");
        
        return (true, "");
    }
}