using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class ToolsFactoryInstaller : MonoInstaller
    {
        [SerializeField]
        private ToolsFactoryConfig config;
        
        public override void InstallBindings()
        {
            BindToolsFactoryData();
            BindPickaxeFactory();
        }

        private void BindToolsFactoryData() => Container.Bind<ToolsFactoryConfig>().FromInstance(config).AsSingle();

        private void BindPickaxeFactory() => Container.Bind<IToolsFactory>().To<ToolsFactory>().AsSingle();
    }
}