using FSOServer.Managers;
using FSOServer.World;
using Lidgren.Network;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOServer.Packets
{
    public interface ICommand
    {
        void Run(GameServer server, GameWorld gameworld, DatabaseManager Database);
    }
}
