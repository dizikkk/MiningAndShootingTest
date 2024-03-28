using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class BlockCollector : MonoBehaviour
    {
        private BlockCollectorService blockCollectorService;
        
        [Inject]
        public void Construct(BlockCollectorService blockCollectorService)
        {
            this.blockCollectorService = blockCollectorService;
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out Block block)) 
                blockCollectorService.AddBlock(block);
        }
        
        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.TryGetComponent(out Block block)) 
                blockCollectorService.RemoveBlock(block);
        }
    }
}