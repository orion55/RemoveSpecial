using RemoveSpecial;

var settings = new Settings();

try
{
    var processor = new Processor(settings.Path);
    processor.Rename();
    
    Console.WriteLine("Press any key to exit the process...");
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
}