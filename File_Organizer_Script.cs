try
{
    var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.txt");

    foreach (string currentFile in txtFiles)
    {
        string fileName = currentFile.Substring(sourceDirectory.Length + 1);
        Directory.Move(currentFile, Path.Combine(destinationDirectory, fileName));
    }
}