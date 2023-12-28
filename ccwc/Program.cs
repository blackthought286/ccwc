// sample file name. In the future we need to be able to pick any file

using ccwc.Features;

if (args.Length < 1)
{
    Console.WriteLine("Please specify a file name");
    return;
}

var cmdFlag = "";
var filePath = "";

if (args.Length > 1)
{
    cmdFlag = args[0];
    filePath = args[1];
}
else
{
    cmdFlag = args[0];
}

switch (cmdFlag)
{
    case "-c":
    {
        var fileSize = FileBytesData.GetFileBytes(filePath);
    
        Console.WriteLine($"File Size: {fileSize}");
        break;
    }
    case "-l":
    {
        var fileLines = FileLinesData.GetLinesInFile(filePath);
        Console.WriteLine($"File Lines: {fileLines}");
        break;
    }
    case "-w":
    {
        var fileAmountOfWords = FileWordsData.GetWordsInFile(filePath);
        Console.WriteLine($"File Words: {fileAmountOfWords}");
        break;
    }
    case "-m":
    {
        var fileAmountOfChars = FileWordsData.GetCharInFile(filePath);
        Console.WriteLine($"File Chars: {fileAmountOfChars}");
        break;
    }
    default:
    {
        if (cmdFlag != "-c" && cmdFlag != "-l" && cmdFlag != "-w" && cmdFlag != "-m" && args.Length > 0)
        {
            try
            {
                // check to see if path is legit
                var path = Path.GetFullPath(args[0]);
                
                var fileSize = FileBytesData.GetFileBytes(path);
                
                var fileLines = FileLinesData.GetLinesInFile(path);
                
                var fileAmountOfWords = FileWordsData.GetWordsInFile(path);
                var fileAmountOfChars = FileWordsData.GetCharInFile(path);
        
                Console.WriteLine($"File Size: {fileSize}, File Lines: {fileLines}, File Words: {fileAmountOfWords}, File Chars: {fileAmountOfChars}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
    
        }

        break;
    }
}
