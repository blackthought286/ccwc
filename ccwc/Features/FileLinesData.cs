namespace ccwc.Features;

public static class FileLinesData
{
    public static long GetLinesInFile(string fileName)
    {
        try
        {
            var fi = new FileInfo(fileName);
            return File.ReadLines(fi.FullName).Count();
        }
        catch (Exception e)
        {
            Console.WriteLine("The correct file path was not found");
            throw;
        }
    }
}