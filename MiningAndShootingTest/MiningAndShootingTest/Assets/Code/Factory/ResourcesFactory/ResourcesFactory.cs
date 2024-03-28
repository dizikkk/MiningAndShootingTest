using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class ResourcesFactory : IResourcesFactory
    {
        private readonly DiContainer diContainer;
        private readonly ResourcesFactoryConfig config;
        
        public ResourcesFactory(DiContainer diContainer, ResourcesFactoryConfig config)
        {
            this.diContainer = diContainer;
            this.config = config;
        }
        
        public Coal CreateCoal()
        {
            Coal coal = diContainer.InstantiatePrefabForComponent<Coal>(
                config.coalPrefab, 
                Vector3.zero, 
                Quaternion.identity,
                null);

            diContainer.Bind<Coal>().FromInstance(coal);
            return coal;
        }
    }
}