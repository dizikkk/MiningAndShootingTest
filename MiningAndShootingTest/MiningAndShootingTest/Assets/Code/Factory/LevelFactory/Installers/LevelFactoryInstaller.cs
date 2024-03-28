using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class LevelFactoryInstaller : MonoInstaller
    {
        [SerializeField]
        private LevelFactoryConfig config;
        
        public override void InstallBindings()
        {
            BindLevelFactoryData();
            BindLevelFactory();
            BindLevelBoundary();
        }

        private void BindLevelFactoryData() => Container.Bind<LevelFactoryConfig>().FromInstance(config).AsSingle();

        
        private void BindLevelFactory() => Container.Bind<ILevelFactory>().To<LevelFactory>().AsSingle();

        private void BindLevelBoundary() => Container.Bind<LevelBoundary>().AsSingle();
    }
}