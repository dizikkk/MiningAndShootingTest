using System;
using System.Collections.Generic;
using UnityEngine;

namespace MiningAndShooting
{
    public class EnemyCollectorService
    {
        private Settings settings;
        private List<Enemy> enemies = new List<Enemy>();
        private Player player;
        
        public EnemyCollectorService(Player player, Settings settings)
        {
            this.settings = settings;
            this.player = player;
        }

        public void AddEnemy(Enemy enemy) => enemies.Add(enemy);
        public void RemoveEnemy(Enemy enemy) => enemies.Remove(enemy);

        public Enemy GetNearestEnemy()
        {
            if (enemies.Count <= 0) return null;
            
            for (int i = 0; i < enemies.Count; i++)
            {
                float distance = Vector2.Distance(player.transform.position, enemies[i].transform.position);
                if (distance < settings.minDistance) return enemies[i];
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