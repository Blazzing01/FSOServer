using FSOServer.Managers;
using FSOServer.World;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSOServer.Packets
{
    internal class CharacterListRequest : ICommand
    {
        public void Run(GameServer server, GameWorld gameworld, DatabaseManager Database)
        {
            throw new NotImplementedException();
        }
    }
}
