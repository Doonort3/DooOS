﻿// Shut down (выключение)

using DoonortOS.Core;
using DoonortOS.Types;

namespace DoonortOS.Core
{
    public class CLI_SHUTDOWN : CLICommand
    {
        public CLI_SHUTDOWN()
        {
            names = new string[2]
            {
                "power-off", "shutdown"
            };
            completed = false;
        }

        public override void Execute(string[] args)
        {
            CLI.Shutdown();

            base.Execute(args);
        }
    }
}