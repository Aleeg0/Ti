using System.Numerics;

namespace Lab4;

public static class FileService
{
    public static List<string> ReadAllLines(string filename)
    {
        return File.ReadAllLines(filename).ToList();
    }

    public static void WriteToFile(string filename, List<string> text, BigInteger sign)
    {
        using var fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
        using var sw = new StreamWriter(fs);
        
        foreach (var line in text)
        {
            sw.WriteLine(line);
        }
        sw.WriteLine(sign.ToString());
        
        sw.Flush();
    }
}