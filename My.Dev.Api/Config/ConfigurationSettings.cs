namespace My.Dev.Api.Config
{
    /// <summary>
    /// C# model representation of appsettings.json
    /// </summary>
    public class ConfigurationSettings : IConfigurationSettings
    {
        public virtual AppConfiguration AppConfiguration { get; set; }
    }
}