using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class ResourcesFactoryInstaller : MonoInstaller
    {
        [SerializeField]
        private ResourcesFactoryConfig config;
        
        public override void InstallBindings()
        {
            BindResourcesFactoryData();
            BindResourcesFactory();
        }

        private void BindResourcesFactoryData() => Container.Bind<ResourcesFactoryConfig>().FromInstance(config).AsSingle();

        private void BindResourcesFactory() => Container.Bind<IResourcesFactory>().To<ResourcesFactory>().AsSingle();
    }
}