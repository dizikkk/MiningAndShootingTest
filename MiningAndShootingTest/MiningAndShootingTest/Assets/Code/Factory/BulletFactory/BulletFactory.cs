using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class BulletFactory : IBulletFactory
    {
        private readonly DiContainer diContainer;
        private readonly BulletFactoryConfig config;

        public BulletFactory(DiContainer diContainer, BulletFactoryConfig config)
        {
            this.diContainer = diContainer;
            this.config = config;
        }
        
        public Bullet Create()
        {
            Bullet bullet = diContainer.InstantiatePrefabForComponent<Bullet>(
                config.bulletPrefab,
                Vector3.zero, 
                Quaternion.identity,
                null);

            return bullet;
        }
    }
}