using FarDragi.DiscordCs.Core.Models.Collections;
using System;
using System.Configuration;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Test
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

            ClasseMortaDeTeste teste = new ClasseMortaDeTeste();
            teste.Teste();

            DiscordCsTest apiTest = new DiscordCsTest(token);
            await apiTest.Start();
        }
    }
}
