using RemoveSpecial;

var settings = new Settings();

try
{
    var processor = new Processor(settings.Path);
    processor.Rename();
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
}