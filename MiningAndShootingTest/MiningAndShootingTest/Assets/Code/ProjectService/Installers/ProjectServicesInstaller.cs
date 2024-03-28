using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class ProjectServicesInstaller : MonoInstaller
    {
        [SerializeField]
        private UIService uiServicePrefab;
        
        [SerializeField]
        private ExitGameService exitGameServicePrefab;
        
        public override void InstallBindings()
        {
            BindUIService();
            BindExitGameService();
        }

        private void BindUIService() => 
            Container.Bind<IUIService>().To<UIService>().FromInstance(uiServicePrefab).AsSingle();
        
        private void BindExitGameService() => 
            Container.BindInterfacesTo<ExitGameService>().FromComponentInNewPrefab(exitGameServicePrefab).AsSingle();
    }
}