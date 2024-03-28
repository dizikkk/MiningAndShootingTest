using System.Linq;
using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class UIFactory : IUIFactory
    {
        private readonly DiContainer diContainer;
        private readonly UIFactoryConfig config;
        
        public UIFactory(DiContainer diContainer, UIFactoryConfig config)
        {
            this.diContainer = diContainer;
            this.config = config;
        }
        
        public void Create()
        {
            CreateCanvas<OverlayCanvas>();
            CreateCanvas<WorldCanvas>();
            CreateCanvas<JoystickCanvas>();
        }

        private void CreateCanvas<T>() where T : Canvas
        {
            Canvas canvasPrefab = config.canvasPrefabs.First(x => x is T);
            if (canvasPrefab == null) return;
            Canvas canvas = diContainer.InstantiatePrefabForComponent<T>(canvasPrefab);
            canvas.Init();
        }
    }
}
    