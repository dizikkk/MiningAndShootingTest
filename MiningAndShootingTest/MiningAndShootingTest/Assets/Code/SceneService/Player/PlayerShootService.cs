using System;
using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class PlayerShootService : ITickable
    {
        private IBulletFactory bulletFactory;
        private EnemyCollectorService enemyCollectorService;
        private Player player;
        private Settings settings;

        private float lastShootTime;
        
        public PlayerShootService(
            IBulletFactory bulletFactory, 
            EnemyCollectorService enemyCollectorService,
            Player player,
            Settings settings)
        {
            this.bulletFactory = bulletFactory;
            this.enemyCollectorService = enemyCollectorService;
            this.player = player;
            this.settings = settings;
        }

        private void Shoot()
        {
            Enemy enemy = enemyCollectorService.GetNearestEnemy();
            if (enemy == null) return;
            Bullet bullet = bulletFactory.Create();
            bullet.transform.position = player.transform.position;
            bullet.transform.right = player.transform.position - enemy.transform.position;
        }

        public void Tick()
        {
            if (Time.realtimeSinceStartup - lastShootTime > settings.reloadTime)
            {
                lastShootTime = Time.realtimeSinceStartup;
                Shoot();
            }
        }
        
        [Serializable]
        public class Settings
        {
            public float reloadTime;
        }
    }
}