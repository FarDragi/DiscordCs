﻿using FarDragi.DiscordCs;
using System;
using System.Threading.Tasks;

namespace BotTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Client client = new(new ClientConfig
            {
                Token = ""
            });

            client.Login();

            await Task.Delay(-1);
        }
    }
}
