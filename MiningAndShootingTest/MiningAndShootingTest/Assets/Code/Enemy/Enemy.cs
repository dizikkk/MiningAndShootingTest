using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class Enemy : MonoBehaviour
    {
        private EnemyMoveService moveService;
        private EnemyHealthService healthService;
        private EnemyAttackTargetService attackTargetService;
        private IEnemyFactory enemyFactory;
        private Player player;
        
        [Inject]
        private void Construct(
            EnemyModel model,
            EnemyMoveService moveService, 
            Player player, 
            EnemyHealthService healthService,
            IEnemyFactory enemyFactory,
            EnemyAttackTargetService attackTargetService)
        {
            this.moveService = moveService;
            this.player = player;
            this.healthService = healthService;
            this.enemyFactory = enemyFactory;
            this.attackTargetService = attackTargetService;
        }
        
        private void FixedUpdate()
        {
            Move(player.transform.position);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.TryGetComponent(out Player player)) return;
            attackTargetService.AddTarget(player);
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (!other.TryGetComponent(out Player player)) return;
            attackTargetService.RemoveTarget();
        }

        private void Move(Vector3 playerPosition) => moveService.Move(playerPosition);

        public void GetDamage()
        {
            healthService.GetDamage();
            CheckHealth();
        }
        
        private void CheckHealth()
        {
            if (!(healthService.GetHealthPoints() <= 0f)) return;
            enemyFactory.Create();
            Destroy(gameObject);
        }
    }
}
