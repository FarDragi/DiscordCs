using FarDragi.DiscordCs.Core.Base.Client;
using FarDragi.DiscordCs.Core.Base.Models.Base;
using FarDragi.DiscordCs.Core.Base.Models.Collections;
using System;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace FarDragi.DiscordCs.Teste
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
