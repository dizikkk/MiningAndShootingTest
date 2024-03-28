using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    [CreateAssetMenu(fileName = "EnemySettingsInstaller", menuName = "Game/Enemy/New EnemySettingsInstaller", order = 0)]
    public class EnemySettingsInstaller : ScriptableObjectInstaller<EnemySettingsInstaller>
    {
        public EnemyMoveService.Settings enemyMoveServiceSettings;
        public EnemyHealthService.Settings enemyHealthServiceSettings;
        public EnemyAttackService.Settings enemyAttackService;
        
        public override void InstallBindings()
        {
            Container.BindInstance(enemyMoveServiceSettings).IfNotBound();
            Container.BindInstance(enemyHealthServiceSettings).IfNotBound();
            Container.BindInstance(enemyAttackService).IfNotBound();
        }
    }
}