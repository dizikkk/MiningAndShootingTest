using System.Threading.Tasks;
using Zenject;

namespace MiningAndShooting
{
    public class GameFactory : IGameFactory
    {
        private IEnemyFactory enemyFactory;
        private ILevelFactory levelFactory;
        private IPlayerFactory playerFactory;
        private IUIFactory uiFactory;
        private ICameraFactory cameraFactory;
        private IToolsFactory toolsFactory;
        
        [Inject]
        public GameFactory(
            IEnemyFactory enemyFactory, 
            ILevelFactory levelFactory, 
            IPlayerFactory playerFactory,
            IUIFactory uiFactory,
            ICameraFactory cameraFactory,
            IToolsFactory toolsFactory)
        {
            this.enemyFactory = enemyFactory;
            this.levelFactory = levelFactory;
            this.playerFactory = playerFactory;
            this.uiFactory = uiFactory;
            this.cameraFactory = cameraFactory; 
            this.toolsFactory = toolsFactory; 
        }

        public void CreateGameplayEntities()
        {
            CreateTools();
            CreatePlayer();
            CreateCamera();
            CreateEnemy();
        }
        
        private void CreatePlayer() => playerFactory.Create();
        private async void CreateEnemy()
        {
            await Task.Delay(2000);
            for (int i = 0; i < 4; i++) enemyFactory.Create();
        }
        private void CreateCamera() => cameraFactory.Create();
        public void CreateUI() => uiFactory.Create();
        private void CreateTools() => toolsFactory.Create();
    }
}