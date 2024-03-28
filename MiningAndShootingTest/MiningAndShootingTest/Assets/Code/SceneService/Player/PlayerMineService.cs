using System;
using DG.Tweening;
using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class PlayerMineService : ITickable
    {
        private Pickaxe pickaxe;
        private Settings settings;
        private BlockCollectorService collectorService;

        private float lastMineTime;
        
        public PlayerMineService(Pickaxe pickaxe, Settings settings, BlockCollectorService collectorService)
        {
            this.pickaxe = pickaxe;
            this.settings = settings;
            this.collectorService = collectorService;
        }

        private void Mine()
        {
            Block block = collectorService.GetNearestBlock();
            if (block == null) return;
            pickaxe.gameObject.SetActive(true);
            pickaxe.transform.position = block.transform.position;
            pickaxe.WorkAnimation().OnComplete(() =>
            {
                pickaxe.transform.DORotate(Vector3.zero, 0f);
                pickaxe.gameObject.SetActive(false);
                block.GetDamage();
                pickaxe.WorkAnimation().Kill();
            });
        }
        
        [Serializable]
        public class Settings
        {
            public float reloadTime;
        }

        public void Tick()
        {
            if (Time.realtimeSinceStartup - lastMineTime > settings.reloadTime)
            {
                lastMineTime = Time.realtimeSinceStartup;
                Mine();
            }
        }
    }
}