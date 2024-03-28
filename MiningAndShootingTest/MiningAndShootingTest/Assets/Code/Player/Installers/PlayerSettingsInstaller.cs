using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    [CreateAssetMenu(fileName = "PlayerSettingsInstaller", menuName = "Game/Player/New PlayerSettingsInstaller", order = 0)]
    public class PlayerSettingsInstaller : ScriptableObjectInstaller<PlayerSettingsInstaller>
    {
        public PlayerMoveService.Settings playerMoveServiceSettings;
        public PlayerShootService.Settings playerShootServiceSettings;
        public EnemyCollectorService.Settings enemyCollectorServiceSettings;
        public BlockCollectorService.Settings blockCollectorServiceSettings;
        public PlayerHealthService.Settings playerHealthServiceSettings;
        public PlayerMineService.Settings playerMineServiceSettings;
        
        public override void InstallBindings()
        {
            Container.BindInstance(playerMoveServiceSettings).IfNotBound();
            Container.BindInstance(playerShootServiceSettings).IfNotBound();
            Container.BindInstance(enemyCollectorServiceSettings).IfNotBound();
            Container.BindInstance(blockCollectorServiceSettings).IfNotBound();
            Container.BindInstance(playerHealthServiceSettings).IfNotBound();
            Container.BindInstance(playerMineServiceSettings).IfNotBound();
        }
    }
}