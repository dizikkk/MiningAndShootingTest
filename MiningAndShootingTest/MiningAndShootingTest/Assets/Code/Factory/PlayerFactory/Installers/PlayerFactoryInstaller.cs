using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class PlayerFactoryInstaller : MonoInstaller
    {
        [SerializeField]
        private PlayerFactoryConfig config;
        
        public override void InstallBindings()
        {
            BindPlayerFactoryData();
            BindPlayerFactory();
        }

        private void BindPlayerFactoryData() => Container.Bind<PlayerFactoryConfig>().FromInstance(config).AsSingle();

        private void BindPlayerFactory() => Container.Bind<IPlayerFactory>().To<PlayerFactory>().AsSingle();

    }
}