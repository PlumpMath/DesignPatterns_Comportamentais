﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    //ConcreteCommand
    public class ServerCommand : Command
    {
        private Server _server;

        public ServerCommand(Server server)
        {
            this._server = server;
        }

        public override void Execute()
        {
            Console.WriteLine("ServerCommand - ConcreteCommand: Validando Usuario ");
            _server.ValidateUser();
        }
    }
}
