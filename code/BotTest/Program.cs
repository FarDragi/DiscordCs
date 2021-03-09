using FarDragi.DiscordCs;
using FarDragi.DiscordCs.Logging;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace BotTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string token = ConfigurationManager.AppSettings["token"];
            if (token == null)
            {
                Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection settings = configFile.AppSettings.Settings;
                Console.Write("Token: ");
                token = Console.ReadLine();
                settings.Add("token", token);
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }

            Client client = new Client(new ClientConfig
            {
                Identify =
                {
                    Token = token
                },
                LoggingLevel = LoggingLevel.Info
            });

            await client.Login();
        }
    }
}
