using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class EnemyFactoryInstaller : MonoInstaller
    {
        [SerializeField]
        private EnemyFactoryConfig config;
        
        public override void InstallBindings()
        {
            BindEnemyFactoryData();
            BindEnemyFactory();
        }

        private void BindEnemyFactoryData() => Container.Bind<EnemyFactoryConfig>().FromInstance(config).AsSingle();
        
        private void BindEnemyFactory() => Container.Bind<IEnemyFactory>().To<EnemyFactory>().AsSingle();
    }
}