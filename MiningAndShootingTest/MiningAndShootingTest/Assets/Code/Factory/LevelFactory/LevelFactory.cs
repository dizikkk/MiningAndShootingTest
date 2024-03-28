using Zenject;

namespace MiningAndShooting
{
    public class LevelFactory : ILevelFactory
    {
        private readonly DiContainer diContainer;
        private LevelFactoryConfig config;
        private Level level;
        
        public LevelFactory(DiContainer diContainer, LevelFactoryConfig config)
        {
            this.diContainer = diContainer;
            this.config = config;
        }

        public void Create()
        {
            level = diContainer.InstantiatePrefabForComponent<Level>(config.levelPrefab);
        }
    }
}