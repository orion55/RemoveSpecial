using Newtonsoft.Json.Linq;

namespace RemoveSpecial;

public class Settings
{
    public Settings()
    {
        var file = File.ReadAllText("settings.json");
        dynamic jToken = JToken.Parse(file);
        Path = jToken.path;
    }

    public string Path{get; }
}