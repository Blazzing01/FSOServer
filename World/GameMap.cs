using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FSOServer.World
{
    public class GameMap
    {
        private Collection<GamePlayer> Players;
        private string MapName;
        private bool IsAttackable;
        private bool IsPVP;
        private string MapX;
        private string MapY;

        public GameMap(string mapName, bool isAttackable, bool isPVP, string mapX, string mapY)
        {
            MapName = mapName;
            IsAttackable = isAttackable;
            IsPVP = isPVP;
            MapX = mapX;
            MapY = mapY;
        }

        public void Update()
        {
            foreach (GamePlayer player in Players)
            {
                player.Update();
            }
        }



        /// <summary>
        /// Adds player to this map.
        /// </summary>
        /// <param name="player"></param>
        public void AddPlayerToMap(GamePlayer player)
        {
            Players.Add(player);
        }

        /// <summary>
        /// Notifies all clients on this map that a new player has been added to the map.
        /// </summary>
        private void NotifyClients_PlayerAddition()
        {

        }




    }
}
