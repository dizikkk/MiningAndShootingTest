using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class ToolsFactory : IToolsFactory
    {
        private readonly DiContainer diContainer;
        private readonly ToolsFactoryConfig config;
        
        public ToolsFactory(DiContainer diContainer, ToolsFactoryConfig config)
        {
            this.diContainer = diContainer;
            this.config = config;
        }
        
        public Pickaxe Create()
        {
            Pickaxe pickaxe = diContainer.InstantiatePrefabForComponent<Pickaxe>(
                config.pickaxePrefab, 
                Vector3.zero, 
                Quaternion.identity,
                null);

            diContainer.Bind<Pickaxe>().FromInstance(pickaxe).AsSingle().NonLazy();
            pickaxe.gameObject.SetActive(false);
            return pickaxe;
        }
    }
}