namespace ccwc.Features;

public static class FileWordsData
{
    public static int GetWordsInFile(string fileName)
    {
        var wordCount = 0;
        using (var sr = new StreamReader(fileName))
        {
            while (sr.ReadLine() is { } line)
            {
                var words = line.Split(' ');
                wordCount += words.Length;
            }
        }

        return wordCount;
    }

    public static int GetCharInFile(string fileName)
    {
        var charCount = 0;
        using (var sr = new StreamReader(fileName))
        {
            while (sr.ReadLine() is { } line)
            {
                var chars = line.ToCharArray();
                charCount += chars.Length;
            }
        }

        return charCount;
    }
}