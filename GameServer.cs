using FSOServer.Managers;
using FSOServer.World;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FSOServer
{
    public class GameServer
    {
        private DatabaseManager _DBManager;
        private ServerManager _ServerManager;
        private GameWorld _GameWorld;

        public GameServer()
        {
            _GameWorld = new GameWorld();
            _DBManager = new DatabaseManager();
            _ServerManager = new ServerManager(_DBManager, _GameWorld, this);
        }

        /// <summary>
        /// Updates the server 1 step in the game loop. This should be called at a fixed interval (e.g., every 50ms) to ensure consistent game updates.
        /// </summary>
        public void UpdateServerTick()
        {
            _GameWorld.Update();
        }
    }
}
