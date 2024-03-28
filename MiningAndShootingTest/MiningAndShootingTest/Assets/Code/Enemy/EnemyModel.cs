using UnityEngine;

namespace MiningAndShooting
{
    public class EnemyModel
    {
        private readonly Rigidbody2D rigidbody;
        private readonly NavMeshAgent2D navMeshAgent;

        public EnemyModel(Rigidbody2D rigidbody, NavMeshAgent2D navMeshAgent)
        {
            this.rigidbody = rigidbody;
            this.navMeshAgent = navMeshAgent;
        }

        public Rigidbody2D GetRigidbody() => rigidbody;

        public NavMeshAgent2D GetNavMeshAgent() => navMeshAgent;
    }
}