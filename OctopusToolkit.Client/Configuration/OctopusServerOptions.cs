namespace OctopusToolkit.Client.Configuration;

public class OctopusServerOptions
{
    public string ServerAddress { get; set; }
    public string ApiKey { get; set; }
    public string SpaceName { get; set; }

    public override string ToString()
    {
        return $"[ServerAddress: {ServerAddress}, ApiKey: {ApiKey}, SpaceName: {SpaceName}]";
    }
}