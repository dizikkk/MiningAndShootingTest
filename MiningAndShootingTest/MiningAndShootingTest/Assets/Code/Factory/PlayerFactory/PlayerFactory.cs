using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class PlayerFactory : IPlayerFactory
    {
        private readonly DiContainer diContainer;
        private readonly PlayerFactoryConfig config;
        
        public PlayerFactory(DiContainer diContainer, PlayerFactoryConfig config)
        {
            this.diContainer = diContainer;
            this.config = config;
        }
        
        public void Create()
        {
            Player player = diContainer.InstantiatePrefabForComponent<Player>(
                config.playerPrefab, 
                config.spawnPosition,
                Quaternion.identity,
                null);

            diContainer.Bind<Player>().FromInstance(player).AsSingle().NonLazy();
        }
    }
}