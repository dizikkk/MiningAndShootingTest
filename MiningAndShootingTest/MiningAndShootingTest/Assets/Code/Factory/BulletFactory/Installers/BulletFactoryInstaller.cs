using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class BulletFactoryInstaller : MonoInstaller
    {
        [SerializeField]
        private BulletFactoryConfig config;
        
        public override void InstallBindings()
        {
            BindBulletFactoryData();
            BindBulletFactory();
        }
        
        private void BindBulletFactoryData() => Container.Bind<BulletFactoryConfig>().FromInstance(config).AsSingle();
        
        private void BindBulletFactory() => Container.Bind<IBulletFactory>().To<BulletFactory>().AsSingle();
    }
}