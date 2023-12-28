namespace ccwc.Features;

public static class FileBytesData
{
    public static long GetFileBytes(string fileName)
    {
        var fi = new FileInfo(fileName);
        return fi.Length;
    }
}