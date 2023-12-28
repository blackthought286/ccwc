namespace ccwc.Features;

public static class FileLinesData
{
    public static long GetLinesInFile(string fileName)
    {
        var fi = new FileInfo(fileName);
        return File.ReadLines(fi.FullName).Count();
    }
}