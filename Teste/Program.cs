using FarDragi.DragiCordApi.Core.Base.Client;
using FarDragi.DragiCordApi.Core.Base.Models.Base;
using System;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace FarDragi.DragiCordApi.Teste
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

            DragiCordApiTest apiTest = new DragiCordApiTest(token);
            await apiTest.Start();
        }
    }
}
