using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class EnemyCollector : MonoBehaviour
    {
        private EnemyCollectorService enemyCollectorService;
        
        [Inject]
        public void Construct(EnemyCollectorService enemyCollectorService)
        {
            this.enemyCollectorService = enemyCollectorService;
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out Enemy enemy)) 
                enemyCollectorService.AddEnemy(enemy);
        }
        
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.TryGetComponent(out Enemy enemy)) 
                enemyCollectorService.RemoveEnemy(enemy);
        }
    }
}