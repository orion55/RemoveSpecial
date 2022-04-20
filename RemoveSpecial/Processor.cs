﻿using System.Text.RegularExpressions;

namespace RemoveSpecial;

public class Processor
{
    private readonly string _path;
    private readonly Regex _compiledUnicodeRegex = new Regex(@"[^\u0000-\u007F|^\u0400-\u04FF]", RegexOptions.Compiled);
    private readonly Regex _multipleSpacesRegex = new Regex(@"\s+", RegexOptions.Compiled);
    public Processor(string path)
    {
        if (string.IsNullOrEmpty(path))
            throw new Exception("The \"path\" value is empty");
        if (!Directory.Exists(path)) 
            throw new Exception("The directory "+path+" does not exist!");
        
        _path = path;
    }

    public void Rename()
    {
        var files = Directory.GetFiles(_path, "*.*", SearchOption.AllDirectories);
        foreach (var fileName in files)
        {
            var newName = StripCharacters(fileName);
            Console.WriteLine("{0} ", newName);
        }
        
    }

    private string StripCharacters(string inputValue)
    {
        var line = _compiledUnicodeRegex.Replace(inputValue, String.Empty);
        line = _multipleSpacesRegex.Replace(line, " ");
        return line.Trim();
    }
}