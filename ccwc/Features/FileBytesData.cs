namespace ccwc.Features;

public static class FileBytesData
{
    public static long GetFileBytes(string fileName)
    {
        try
        {
            var fi = new FileInfo(fileName);
            return fi.Length;
        }
        catch (Exception e)
        {
            Console.WriteLine("The correct file path was not found");
            throw;
        }
    }
}