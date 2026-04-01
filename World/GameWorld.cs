using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FSOServer.World
{
    public class GameWorld
    {
        private Collection<GameMap> LoadedMaps = new Collection<GameMap>();
        public GameWorld()
        {
        }

        public void Update()
        {
            foreach (GameMap map in LoadedMaps)
            {
                map.Update();
            }
        }

        /// <summary>
        /// Adds player to world/map.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="map"></param>
        public void AddPlayer(GamePlayer player, GameMap map)
        {
            foreach (GameMap loadedMap in LoadedMaps)
            {
                if (loadedMap == map)
                {
                    loadedMap.AddPlayerToMap(player);
                    return;
                }
            }
        }


    }
}
