using System;
using System.Collections.Generic;
using UnityEngine;

namespace MiningAndShooting
{
    public class BlockCollectorService
    {
        private Settings settings;
        private List<Block> blocks = new List<Block>();
        private Player player;
        
        public BlockCollectorService(Player player, Settings settings)
        {
            this.settings = settings;
            this.player = player;
        }

        public void AddBlock(Block block) => blocks.Add(block);
        public void RemoveBlock(Block block) => blocks.Remove(block);

        public Block GetNearestBlock()
        {
            if (blocks.Count <= 0) return null;
            
            for (int i = 0; i < blocks.Count; i++)
            {
                float distance = Vector2.Distance(player.transform.position, blocks[i].transform.position);
                if (distance < settings.minDistance) return blocks[i];
            }

            return null;
        }

        [Serializable]
        public class Settings
        {
            public float minDistance;
        }
    }
}