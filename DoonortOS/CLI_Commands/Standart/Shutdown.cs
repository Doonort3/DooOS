﻿// Shut down (выключение)

namespace Doos_cli.Core
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