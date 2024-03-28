using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class EnemyFactory : IEnemyFactory
    {
        private readonly DiContainer diContainer;
        private readonly EnemyFactoryConfig config;
        private readonly LevelBoundary levelBoundary;
        
        public EnemyFactory(DiContainer diContainer, EnemyFactoryConfig config, LevelBoundary levelBoundary)
        {
            this.diContainer = diContainer;
            this.config = config;
            this.levelBoundary = levelBoundary;
        }
        
        public void Create()
        {
            Enemy enemy = diContainer.InstantiatePrefabForComponent<Enemy>(
                config.enemyPrefab,
                levelBoundary.ChooseRandomStartPosition(), 
                Quaternion.identity,
                null);

            diContainer.Bind<Enemy>().FromInstance(enemy);
        }
    }
}