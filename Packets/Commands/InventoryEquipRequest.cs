using FSOServer.Managers;
using FSOServer.World;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOServer.Packets
{
    internal class InventoryEquipRequest : ICommand
    {
        void ICommand.Run(GameServer server, GameWorld gameworld, DatabaseManager Database)
        {
            throw new NotImplementedException();
        }
    }
}
