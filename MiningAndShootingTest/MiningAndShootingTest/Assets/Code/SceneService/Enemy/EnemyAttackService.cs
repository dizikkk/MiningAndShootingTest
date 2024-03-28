using System;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class EnemyAttackService : ITickable
    {
        private Settings settings;
        private Player player;
        private EnemyAttackTargetService attackTargetService;

        private float lastAttackTime;
        
        public EnemyAttackService(Player player, Settings settings, EnemyAttackTargetService attackTargetService)
        {
            this.settings = settings;
            this.player = player;
            this.attackTargetService = attackTargetService;
        }

        public void Attack()
        {
            player.GetDamage();
        }

        public void Tick()
        {
            if (attackTargetService.TryGetTarget())
            {
                if (Time.realtimeSinceStartup - lastAttackTime > settings.reloadTime)
                {
                    lastAttackTime = Time.realtimeSinceStartup;
                    Attack();
                }
            }
        }
        
        [Serializable]
        public class Settings
        {
            public float reloadTime;
        }
    }
}