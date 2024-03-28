namespace MiningAndShooting
{
    public class EnemyAttackTargetService
    {
        private Player player;
        
        public void AddTarget(Player player) => this.player = player;
        public void RemoveTarget() => player = null;
        public bool TryGetTarget() => player != null;
    }
}